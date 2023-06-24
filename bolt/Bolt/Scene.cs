using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	internal struct Scene
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x900E00", Offset = "0x8FF400", VA = "0x180900E00")]
		public Scene(int index, int sequence)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x900E10", Offset = "0x8FF410", VA = "0x180900E10", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x900E20", Offset = "0x8FF420", VA = "0x180900E20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x900EB0", Offset = "0x8FF4B0", VA = "0x180900EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x65FF70", Offset = "0x65E570", VA = "0x18065FF70")]
		public static bool operator ==(Scene a, Scene b)
		{
			return default(bool);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x65FF90", Offset = "0x65E590", VA = "0x18065FF90")]
		public static bool operator !=(Scene a, Scene b)
		{
			return default(bool);
		}

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x0")]
		public readonly int Index;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x4")]
		public readonly int Sequence;
	}
}
