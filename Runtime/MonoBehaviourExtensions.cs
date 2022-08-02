using UnityEngine;
using System.Collections;

namespace Letete.Utils.Runtime
{
	public static class MonoBehaviourExtensions
	{
		public delegate void InvokeCallback();
		
		public static void Invoke(this MonoBehaviour mb, float waitSeconds, InvokeCallback callback, bool unscaledTime = false)
		{
			if(mb.gameObject.activeInHierarchy)
            {
				mb.StartCoroutine(InvokeCoroutine(waitSeconds, callback, unscaledTime));
            }
		}

		private static IEnumerator InvokeCoroutine(float waitSeconds, InvokeCallback callback, bool unscaledTime)
        {
			if(unscaledTime)
            {
				yield return new WaitForSecondsRealtime(waitSeconds);
            }
			else
            {
				yield return new WaitForSeconds(waitSeconds);
            }
			callback.Invoke();
        }
	}
}