using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public class InteractionPointLookup : IInteractionPointLookup
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002A44 File Offset: 0x00000C44
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007F")]
		public float MaxGrabDistance
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000080")]
		public IAimRayProvider AimRayProvider
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000081")]
		public ITargetFaceProvider TargetFaceProvider
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2D9B9E0", Offset = "0x2D99FE0", VA = "0x182D9B9E0", Slot = "4")]
		public bool TryGetTargetInteractionPoint(out InteractionPoint targetIp)
		{
			return default(bool);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2D9BB50", Offset = "0x2D9A150", VA = "0x182D9BB50")]
		private bool TryFindInteractablePointInFace(BlueprintFace face, out InteractionPoint targetIp)
		{
			return default(bool);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public InteractionPointLookup()
		{
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x10")]
		private Ray _aimRay;
	}
}
