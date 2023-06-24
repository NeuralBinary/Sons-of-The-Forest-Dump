using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.AssetInfo
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[CreateAssetMenu(fileName = "AssetInfo", menuName = "NWH/AssetInfo", order = 0)]
	public class AssetInfo : ScriptableObject
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x26E32A0", Offset = "0x26E18A0", VA = "0x1826E32A0")]
		public AssetInfo()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		public string assetName;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		public string version;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		public string upgradeNotesURL;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		public string changelogURL;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x38")]
		public string quickStartURL;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x40")]
		public string documentationURL;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x48")]
		public string discordURL;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x50")]
		public string forumURL;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x58")]
		public string emailURL;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x60")]
		public string assetURL;
	}
}
