using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	[AddComponentMenu("Sons/Construction/DecorationStructure")]
	public class DecorationStructure : Structure
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000292")]
		public static Counter Counter
		{
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x2E8FBF0", Offset = "0x2E8E1F0", VA = "0x182E8FBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00006974 File Offset: 0x00004B74
		[Token(Token = "0x17000293")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x9E6210", Offset = "0x9E4810", VA = "0x1809E6210", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0000698C File Offset: 0x00004B8C
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x2E8FC40", Offset = "0x2E8E240", VA = "0x182E8FC40", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000069A4 File Offset: 0x00004BA4
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x2E8FCF0", Offset = "0x2E8E2F0", VA = "0x182E8FCF0")]
		public DecorationStructure()
		{
		}
	}
}
