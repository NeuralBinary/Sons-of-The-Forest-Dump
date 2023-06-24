using System;
using Crest;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Environment
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public class OceanManager : SingletonBehaviour<OceanManager>
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2D2F800", Offset = "0x2D2DE00", VA = "0x182D2F800")]
		public static void EnableUnderwaterEffect(bool enabled)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2D2F8B0", Offset = "0x2D2DEB0", VA = "0x182D2F8B0")]
		public OceanManager()
		{
		}

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OceanRenderer _oceanRenderer;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CustomPassVolume _underwaterEffectVolume;
	}
}
