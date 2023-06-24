using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	[RequireComponent(typeof(ObiRope))]
	[AddComponentMenu("Physics/Obi/Obi Rope Cursor", 882)]
	public class ObiRopeCursor : MonoBehaviour
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x000050E4 File Offset: 0x000032E4
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700017D")]
		public float cursorMu
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x280A740", Offset = "0x2808D40", VA = "0x18280A740")]
			set
			{
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x000050FC File Offset: 0x000032FC
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700017E")]
		public float sourceMu
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x280A750", Offset = "0x2808D50", VA = "0x18280A750")]
			set
			{
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700017F")]
		public ObiStructuralElement cursorElement
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x280A760", Offset = "0x2808D60", VA = "0x18280A760")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00005114 File Offset: 0x00003314
		[Token(Token = "0x17000180")]
		public int sourceParticleIndex
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x280A790", Offset = "0x2808D90", VA = "0x18280A790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x280A7C0", Offset = "0x2808DC0", VA = "0x18280A7C0")]
		private void Awake()
		{
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x280A9E0", Offset = "0x2808FE0", VA = "0x18280A9E0")]
		private void Actor_OnElementsGenerated(ObiActor actor)
		{
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x280AA00", Offset = "0x2809000", VA = "0x18280AA00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x280AB50", Offset = "0x2809150", VA = "0x18280AB50")]
		public void UpdateCursor()
		{
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x280ACF0", Offset = "0x28092F0", VA = "0x18280ACF0")]
		public void UpdateSource()
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0000512C File Offset: 0x0000332C
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x280AEA0", Offset = "0x28094A0", VA = "0x18280AEA0")]
		private int AddParticleAt(int index)
		{
			return 0;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x280B050", Offset = "0x2809650", VA = "0x18280B050")]
		private void RemoveParticleAt(int index)
		{
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x280B0A0", Offset = "0x28096A0", VA = "0x18280B0A0")]
		public void ChangeLength(float newLength)
		{
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x280BB90", Offset = "0x280A190", VA = "0x18280BB90")]
		public ObiRopeCursor()
		{
		}

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x20")]
		private ObiRope rope;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		[Range(0f, 1f)]
		private float m_CursorMu;

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		[Range(0f, 1f)]
		private float m_SourceMu;

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0x30")]
		public bool direction;

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		[FieldOffset(Offset = "0x38")]
		private ObiStructuralElement m_CursorElement;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x40")]
		private int m_SourceIndex;
	}
}
