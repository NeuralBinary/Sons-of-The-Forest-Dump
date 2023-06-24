using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	public struct Vector3dTuple3
	{
		// Token: 0x060012E7 RID: 4839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x1E4E120", Offset = "0x1E4C720", VA = "0x181E4E120")]
		public Vector3dTuple3(Vector3d v0, Vector3d v1, Vector3d v2)
		{
		}

		// Token: 0x17000308 RID: 776
		[Token(Token = "0x17000308")]
		public Vector3d this[int key]
		{
			[Token(Token = "0x60012E8")]
			[Address(RVA = "0x1E38660", Offset = "0x1E36C60", VA = "0x181E38660")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x60012E9")]
			[Address(RVA = "0x1E4E160", Offset = "0x1E4C760", VA = "0x181E4E160")]
			set
			{
			}
		}

		// Token: 0x040008A0 RID: 2208
		[Token(Token = "0x40008A0")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d V0;

		// Token: 0x040008A1 RID: 2209
		[Token(Token = "0x40008A1")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d V1;

		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0x30")]
		public Vector3d V2;
	}
}
