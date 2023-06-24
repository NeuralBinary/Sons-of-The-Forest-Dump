using System;
using Backtrace.Unity.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Model
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Serializable]
	public class BacktraceClientConfiguration : ScriptableObject
	{
		// Token: 0x06000149 RID: 329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x74A380", Offset = "0x748980", VA = "0x18074A380")]
		public void UpdateServerUrl()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x74A540", Offset = "0x748B40", VA = "0x18074A540")]
		public bool ValidateServerUrl()
		{
			return default(bool);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x74A6E0", Offset = "0x748CE0", VA = "0x18074A6E0")]
		public BacktraceClientConfiguration()
		{
		}

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x18")]
		public string ServerUrl;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x20")]
		public int ReportPerMin;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x24")]
		public bool HandleUnhandledExceptions;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x25")]
		public bool IgnoreSslValidation;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x26")]
		public bool DestroyOnLoad;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x27")]
		public bool HandleANR;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x28")]
		public bool OomReports;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x2C")]
		public int GameObjectDepth;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x30")]
		public MiniDumpType MinidumpType;
	}
}
