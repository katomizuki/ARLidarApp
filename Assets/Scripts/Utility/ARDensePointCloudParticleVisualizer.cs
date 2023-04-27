using System.Linq;
using UnityEngine;

namespace Scenes
{
    // ParticleSystemに点群データを載せる
    [RequireComponent(typeof(ParticleSystem))]
    public class ARDensePointCloudParticleVisualizer : ARDensePointCloudVisualizer 
    {
       public Gradient confidenseGradient;
       public bool useConfidenseColor;
       private ParticleSystem _particleSystem;
       private ParticleSystem.Particle[] _particles;
       
         protected override void Awake()
         {
              base.Awake();
              // ParticleSystemを取得する
              _particleSystem = GetComponent<ParticleSystem>();
              
              // 点群の最大数分のパーティクルを作成する
              var pointCloudManager = FindObjectOfType<ARDensePointCloudManager>();
              if (pointCloudManager != null)
              {
                  _particles = new ParticleSystem.Particle[pointCloudManager.maxPoints];
              }
         }

         protected override void OnEnable()
         {
             base.OnEnable();
             // ParticleSystemを再生する
             if (_particleSystem != null) _particleSystem.Play();
         }

         protected override void OnDisable()
         {
             base.OnDisable();
             // ParticleSystemを停止する
             if (_particles != null) _particleSystem.Stop();
         }

         protected override void OnPointCloudUpdated(PointCloudUpdatedEventArgs args)
         {
             base.OnPointCloudUpdated(args);
             // サイズとアルファ値を取得
             var size = _particleSystem.main.startSize.constant;
             var alpha = _particleSystem.main.startColor.color.a;

             for (var i = args.startIndex; i < args.startIndex + args.count; ++i)
             {
                 // PositionとColor,Sizeを設定する
                 _particles[i].position = args.pointCloud.points[i];
                 _particles[i].startSize = size;
                 
                 // もしグラデーションからーを使用する場合はGradientクラスで色を設定する
                 var color =  useConfidenseColor
                     ? confidenseGradient.Evaluate(args.pointCloud.confidences[i])
                     : (Color) args.pointCloud.colors[i];
                 color.a = alpha;
                 _particles[i].startColor = color;
             }
             
             // ParticleSystemにパーティクルを設定する
             _particleSystem.SetParticles(_particles, args.pointCloud.count);
         }
    }
}