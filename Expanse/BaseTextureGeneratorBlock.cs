using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[ExecuteInEditMode]
	[Serializable]
	public abstract class BaseTextureGeneratorBlock : MonoBehaviour
	{
		// Token: 0x060001F6 RID: 502
		[Token(Token = "0x60001F6")]
		public abstract RTHandle GetTexture();

		// Token: 0x060001F7 RID: 503
		[Token(Token = "0x60001F7")]
		public abstract void ForceUpdate();

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected BaseTextureGeneratorBlock()
		{
		}
	}
}
