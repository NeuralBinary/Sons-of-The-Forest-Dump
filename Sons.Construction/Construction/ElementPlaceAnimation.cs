using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public abstract class ElementPlaceAnimation : ScriptableObject
	{
		// Token: 0x06000076 RID: 118
		[Token(Token = "0x6000076")]
		public abstract void OnPlaced(Transform renderableTr, [Optional] Action onFinished, [Optional] Transform fromTr, bool useCopyOfRenderable = false);

		// Token: 0x06000077 RID: 119
		[Token(Token = "0x6000077")]
		public abstract void OnPlaced(StructureElement element, [Optional] Action onFinished, [Optional] Transform fromTr, bool useCopyOfRenderable = false);

		// Token: 0x06000078 RID: 120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		protected ElementPlaceAnimation()
		{
		}
	}
}
