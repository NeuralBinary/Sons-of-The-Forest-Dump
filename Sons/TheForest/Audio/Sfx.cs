using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Endnight.Attributes;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Audio
{
	// Token: 0x020004C2 RID: 1218
	[Token(Token = "0x20004C2")]
	public class Sfx : MonoBehaviour
	{
		// Token: 0x06001FEF RID: 8175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x330DA40", Offset = "0x330C040", VA = "0x18330DA40")]
		private void Awake()
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x330DB60", Offset = "0x330C160", VA = "0x18330DB60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x6001FF1")]
		public static bool TryPlay<T>(Collider col, [Optional] Transform source, bool mpSync = true) where T : SfxInfo
		{
			return default(bool);
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x330DCA0", Offset = "0x330C2A0", VA = "0x18330DCA0")]
		public static void Play(SfxInfo info, [Optional] Transform source, bool mpSync = true)
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x330DDC0", Offset = "0x330C3C0", VA = "0x18330DDC0")]
		public static void Play(SfxInfo.SfxTypes type, [Optional] Transform source, bool mpSync = true)
		{
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000479")]
		private protected static Sfx Instance
		{
			[Token(Token = "0x6001FF4")]
			[Address(RVA = "0x330DFD0", Offset = "0x330C5D0", VA = "0x18330DFD0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6001FF5")]
			[Address(RVA = "0x330E010", Offset = "0x330C610", VA = "0x18330E010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public Sfx()
		{
		}

		// Token: 0x04001D57 RID: 7511
		[Token(Token = "0x4001D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NameFromEnumIndex(typeof(SfxInfo.SfxTypes))]
		public Sfx.SfxDefinition[] _definitions;

		// Token: 0x020004C3 RID: 1219
		[Token(Token = "0x20004C3")]
		[Serializable]
		public class SfxDefinition
		{
			// Token: 0x06001FF7 RID: 8183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001FF7")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SfxDefinition()
			{
			}

			// Token: 0x04001D59 RID: 7513
			[Token(Token = "0x4001D59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string _path;

			// Token: 0x04001D5A RID: 7514
			[Token(Token = "0x4001D5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public EventInstance _event;
		}
	}
}
