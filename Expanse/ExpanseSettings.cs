using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[VolumeComponentMenu("Sky/Expanse")]
	[SkyUniqueID(20382532)]
	public class ExpanseSettings : SkySettings
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xAF91D0", Offset = "0xAF77D0", VA = "0x180AF91D0", Slot = "10")]
		public override Type GetSkyRendererType()
		{
			return null;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xAF9270", Offset = "0xAF7870", VA = "0x180AF9270", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60003C2")]
		public T getMemberVariable<T>(string name)
		{
			return null;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C3")]
		public void setMemberVariable<T>(string name, T value)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xAF92E0", Offset = "0xAF78E0", VA = "0x180AF92E0")]
		public ExpanseSettings()
		{
		}

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		private const int EXPANSE_UNIQUE_ID = 20382532;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x0")]
		private static int m_fakeHashCode;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("When enabled, Expanse wont update cubemap per frame.")]
		public bool _staticCubeMap;
	}
}
