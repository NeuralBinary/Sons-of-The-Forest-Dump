using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	public abstract class ObiRopeBase : ObiActor
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600098D RID: 2445 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x0600098E RID: 2446 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000014")]
		public event ObiActor.ActorCallback OnElementsGenerated
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x28099C0", Offset = "0x2807FC0", VA = "0x1828099C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x2809AB0", Offset = "0x28080B0", VA = "0x182809AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x000050B4 File Offset: 0x000032B4
		[Token(Token = "0x1700017B")]
		public float restLength
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x2739890", Offset = "0x2737E90", VA = "0x182739890")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700017C")]
		public ObiPath path
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x2809BA0", Offset = "0x28081A0", VA = "0x182809BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000050CC File Offset: 0x000032CC
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x2809CC0", Offset = "0x28082C0", VA = "0x182809CC0")]
		public float CalculateLength()
		{
			return 0f;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x2809ED0", Offset = "0x28084D0", VA = "0x182809ED0")]
		public void RecalculateRestLength()
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x2809F80", Offset = "0x2808580", VA = "0x182809F80")]
		public void RecalculateRestPositions()
		{
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x280A540", Offset = "0x2808B40", VA = "0x18280A540")]
		public void RebuildElementsFromConstraints()
		{
		}

		// Token: 0x06000995 RID: 2453
		[Token(Token = "0x6000995")]
		protected abstract void RebuildElementsFromConstraintsInternal();

		// Token: 0x06000996 RID: 2454 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "37")]
		public virtual void RebuildConstraintsFromElements()
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x280A580", Offset = "0x2808B80", VA = "0x18280A580")]
		public ObiStructuralElement GetElementAt(float mu, out float elementMu)
		{
			return null;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x280A660", Offset = "0x2808C60", VA = "0x18280A660")]
		protected ObiRopeBase()
		{
		}

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected bool m_SelfCollisions;

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0xAC")]
		[HideInInspector]
		[SerializeField]
		protected float restLength_;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public List<ObiStructuralElement> elements;
	}
}
