using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Serializable]
	public class SampleFpsLocation
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x1700000E")]
		public Vector3 Position
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xA6DCA0", Offset = "0xA6C2A0", VA = "0x180A6DCA0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x1700000F")]
		public Vector3 Rotation
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x29A2980", Offset = "0x29A0F80", VA = "0x1829A2980")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000010")]
		public string Id
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x17000011")]
		public bool DontCapture
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SampleFpsLocation()
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 _position;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 _rotation;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _dontCapture;
	}
}
