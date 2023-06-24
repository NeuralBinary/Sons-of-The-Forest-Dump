using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000528 RID: 1320
	[Token(Token = "0x2000528")]
	[Serializable]
	public abstract class SimpleStateUnityObject<T> : SimpleStateValue<T> where T : UnityEngine.Object
	{
		// Token: 0x06002312 RID: 8978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002312")]
		protected SimpleStateUnityObject(T value)
		{
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002313")]
		public override T GetValue()
		{
			return null;
		}

		// Token: 0x04001FEA RID: 8170
		[Token(Token = "0x4001FEA")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T _value;
	}
}
