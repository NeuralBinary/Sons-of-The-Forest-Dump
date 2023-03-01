using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyOcclusion
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	[Serializable]
	public class VersionInfo
	{
		// Token: 0x06001F9C RID: 8092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0x2D376E0", Offset = "0x2D366E0", VA = "0x182D376E0")]
		public static string StaticToString()
		{
			return null;
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0x2D378E0", Offset = "0x2D368E0", VA = "0x182D378E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x1700046C")]
		public int Number
		{
			[Token(Token = "0x6001F9E")]
			[Address(RVA = "0x2D37B70", Offset = "0x2D36B70", VA = "0x182D37B70")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0x2D37AF0", Offset = "0x2D36AF0", VA = "0x182D37AF0")]
		private VersionInfo()
		{
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x2D37B20", Offset = "0x2D36B20", VA = "0x182D37B20")]
		private VersionInfo(byte major, byte minor, byte release)
		{
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x2D37650", Offset = "0x2D36650", VA = "0x182D37650")]
		public static VersionInfo Current()
		{
			return null;
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x2D376B0", Offset = "0x2D366B0", VA = "0x182D376B0")]
		public static bool Matches(VersionInfo version)
		{
			return default(bool);
		}

		// Token: 0x04001D2B RID: 7467
		[Token(Token = "0x4001D2B")]
		public const byte Major = 2;

		// Token: 0x04001D2C RID: 7468
		[Token(Token = "0x4001D2C")]
		public const byte Minor = 0;

		// Token: 0x04001D2D RID: 7469
		[Token(Token = "0x4001D2D")]
		public const byte Release = 3;

		// Token: 0x04001D2E RID: 7470
		[Token(Token = "0x4001D2E")]
		public const byte Revision = 0;

		// Token: 0x04001D2F RID: 7471
		[Token(Token = "0x4001D2F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_major;

		// Token: 0x04001D30 RID: 7472
		[Token(Token = "0x4001D30")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int m_minor;

		// Token: 0x04001D31 RID: 7473
		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_release;
	}
}
