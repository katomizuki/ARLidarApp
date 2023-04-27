using UnityEngine;


public interface ILocalStorageService 
{
   void SetLoalStorage(string key, int value); 
}
public class LocalStorageService : ILocalStorageService 
{
   public void  SetLoalStorage(string key, int value)
   {
       PlayerPrefs.SetInt(key, value);
   }
}
