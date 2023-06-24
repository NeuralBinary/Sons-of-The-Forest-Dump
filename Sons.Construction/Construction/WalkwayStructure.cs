using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000249 RID: 585
	[Token(Token = "0x2000249")]
	[AddComponentMenu("Sons/Construction/WalkwayStructure")]
	public class WalkwayStructure : Structure
	{
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700040D")]
		public static Counter Counter
		{
			[Token(Token = "0x60011D3")]
			[Address(RVA = "0x2F2BA80", Offset = "0x2F2A080", VA = "0x182F2BA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0000AC4C File Offset: 0x00008E4C
		[Token(Token = "0x1700040E")]
		public override ushort TypeID
		{
			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x223C900", Offset = "0x223AF00", VA = "0x18223C900", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0000AC64 File Offset: 0x00008E64
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x2F2BAD0", Offset = "0x2F2A0D0", VA = "0x182F2BAD0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0000AC7C File Offset: 0x00008E7C
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x2F2BCC0", Offset = "0x2F2A2C0", VA = "0x182F2BCC0")]
		public WalkwayStructure()
		{
		}

		// Token: 0x0200024A RID: 586
		[Token(Token = "0x200024A")]
		public static class Utils
		{
			// Token: 0x060011D9 RID: 4569 RVA: 0x0000AC94 File Offset: 0x00008E94
			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x2F2BDE0", Offset = "0x2F2A3E0", VA = "0x182F2BDE0")]
			internal static Vector3 CalcWalkwayPosFromWall(WallStructure targetWall, StructureElement wallPrefab, StructureElement walkwayPrefab, bool targetingRightSide)
			{
				return default(Vector3);
			}
		}
	}
}
