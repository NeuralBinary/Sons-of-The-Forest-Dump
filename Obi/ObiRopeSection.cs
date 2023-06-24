using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	[CreateAssetMenu(fileName = "rope section", menuName = "Obi/Rope Section", order = 142)]
	public class ObiRopeSection : ScriptableObject
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00005234 File Offset: 0x00003434
		[Token(Token = "0x17000193")]
		public int Segments
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x2811E30", Offset = "0x2810430", VA = "0x182811E30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x2811E70", Offset = "0x2810470", VA = "0x182811E70")]
		public void OnEnable()
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x2811F40", Offset = "0x2810540", VA = "0x182811F40")]
		public void CirclePreset(int segments)
		{
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0000524C File Offset: 0x0000344C
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x2812150", Offset = "0x2810750", VA = "0x182812150")]
		public static int SnapTo(float val, int snapInterval, int threshold)
		{
			return 0;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public ObiRopeSection()
		{
		}

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public List<Vector2> vertices;

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x20")]
		public int snapX;

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x24")]
		public int snapY;
	}
}
