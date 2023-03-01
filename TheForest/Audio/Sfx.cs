using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Endnight.Attributes;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Audio
{
	// Token: 0x020004CD RID: 1229
	[Token(Token = "0x20004CD")]
	public class Sfx : MonoBehaviour
	{
		// Token: 0x06001F8B RID: 8075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x2D32230", Offset = "0x2D31230", VA = "0x182D32230")]
		private void Awake()
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0x2D32330", Offset = "0x2D31330", VA = "0x182D32330")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x6001F8D")]
		public static bool TryPlay<T>(Collider col, [Optional] Transform source, bool mpSync = true) where T : SfxInfo
		{
			return default(bool);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x2D32610", Offset = "0x2D31610", VA = "0x182D32610")]
		public static void Play(SfxInfo info, [Optional] Transform source, bool mpSync = true)
		{
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x2D32400", Offset = "0x2D31400", VA = "0x182D32400")]
		public static void Play(SfxInfo.SfxTypes type, [Optional] Transform source, bool mpSync = true)
		{
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F91 RID: 8081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046A")]
		private protected static Sfx Instance
		{
			[Token(Token = "0x6001F90")]
			[Address(RVA = "0x2D326D0", Offset = "0x2D316D0", VA = "0x182D326D0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6001F91")]
			[Address(RVA = "0x2D32710", Offset = "0x2D31710", VA = "0x182D32710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F92")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public Sfx()
		{
		}

		// Token: 0x04001D1B RID: 7451
		[Token(Token = "0x4001D1B")]
		[FieldOffset(Offset = "0x20")]
		[NameFromEnumIndex(typeof(SfxInfo.SfxTypes))]
		public Sfx.SfxDefinition[] _definitions;

		// Token: 0x020004CE RID: 1230
		[Token(Token = "0x20004CE")]
		[Serializable]
		public class SfxDefinition
		{
			// Token: 0x06001F93 RID: 8083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F93")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public SfxDefinition()
			{
			}

			// Token: 0x04001D1D RID: 7453
			[Token(Token = "0x4001D1D")]
			[FieldOffset(Offset = "0x10")]
			public string _path;

			// Token: 0x04001D1E RID: 7454
			[Token(Token = "0x4001D1E")]
			[FieldOffset(Offset = "0x18")]
			public EventInstance _event;
		}
	}
}
