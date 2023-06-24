using System;
using System.Collections;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	public class CoroutineJob
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700014B")]
		public object Result
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x27F3E60", Offset = "0x27F2460", VA = "0x1827F3E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x1700014C")]
		public bool IsDone
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x1700014D")]
		public bool RaisedException
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x26000D0", Offset = "0x25FE6D0", VA = "0x1826000D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x27F3EA0", Offset = "0x27F24A0", VA = "0x1827F3EA0")]
		private void Init()
		{
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x27F3F10", Offset = "0x27F2510", VA = "0x1827F3F10")]
		public static object RunSynchronously(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x27F40D0", Offset = "0x27F26D0", VA = "0x1827F40D0")]
		public IEnumerator Start(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x27F41D0", Offset = "0x27F27D0", VA = "0x1827F41D0")]
		public void Stop()
		{
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CoroutineJob()
		{
		}

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x10")]
		private object result;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x18")]
		private bool isDone;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x19")]
		private bool raisedException;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x1A")]
		private bool stop;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x20")]
		private Exception e;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x28")]
		public int asyncThreshold;

		// Token: 0x020001BB RID: 443
		[Token(Token = "0x20001BB")]
		public class ProgressInfo
		{
			// Token: 0x06000897 RID: 2199 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x24033C0", Offset = "0x24019C0", VA = "0x1824033C0")]
			public ProgressInfo(string userReadableInfo, float progress)
			{
			}

			// Token: 0x0400073C RID: 1852
			[Token(Token = "0x400073C")]
			[FieldOffset(Offset = "0x10")]
			public string userReadableInfo;

			// Token: 0x0400073D RID: 1853
			[Token(Token = "0x400073D")]
			[FieldOffset(Offset = "0x18")]
			public float progress;
		}
	}
}
