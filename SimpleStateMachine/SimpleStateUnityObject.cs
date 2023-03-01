using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000520 RID: 1312
	[Token(Token = "0x2000520")]
	[Serializable]
	public abstract class SimpleStateUnityObject<T> : SimpleStateValue<T> where T : Object
	{
		// Token: 0x06002225 RID: 8741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002225")]
		protected SimpleStateUnityObject(T value)
		{
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002226")]
		public override T GetValue()
		{
			return null;
		}

		// Token: 0x04001F36 RID: 7990
		[Token(Token = "0x4001F36")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T _value;
	}
}
