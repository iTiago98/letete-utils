using UnityEngine;
using System.Collections;

namespace Letete.Utils.Runtime
{
	public static class MonoBehaviourExtensions
	{
		public delegate void InvokeCallback();
		
		public static void Invoke(this MonoBehaviour mb, float waitSeconds, InvokeCallback callback)
		{
			if(mb.gameObject.activeInHierarchy)
            {
				mb.StartCoroutine(InvokeCoroutine(waitSeconds, callback));
            }
		}

		private static IEnumerator InvokeCoroutine(float waitSeconds, InvokeCallback callback)
        {
			yield return new WaitForSeconds(waitSeconds);
			callback.Invoke();
        }
	}
}