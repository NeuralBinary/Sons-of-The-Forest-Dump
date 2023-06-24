using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	[Serializable]
	public abstract class MonoBehaviourStimuliValue<T> : MonoBehaviourStimuli
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D4")]
		protected MonoBehaviourStimuliValue()
		{
		}

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private protected T _value;
	}
}
