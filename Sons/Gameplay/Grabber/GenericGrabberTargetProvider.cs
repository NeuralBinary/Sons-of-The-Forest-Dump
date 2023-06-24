using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Grabber
{
	// Token: 0x02000842 RID: 2114
	[Token(Token = "0x2000842")]
	public class GenericGrabberTargetProvider : IGrabberTargetProvider
	{
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x00012360 File Offset: 0x00010560
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B1")]
		public bool HasTarget
		{
			[Token(Token = "0x6003BDF")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BE0")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x00012378 File Offset: 0x00010578
		// (set) Token: 0x06003BE2 RID: 15330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B2")]
		public bool CleanTargetAfterSelect
		{
			[Token(Token = "0x6003BE1")]
			[Address(RVA = "0x5FD500", Offset = "0x5FBB00", VA = "0x1805FD500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BE2")]
			[Address(RVA = "0x5FD510", Offset = "0x5FBB10", VA = "0x1805FD510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x00012390 File Offset: 0x00010590
		// (set) Token: 0x06003BE4 RID: 15332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B3")]
		public float TargetScore
		{
			[Token(Token = "0x6003BE3")]
			[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003BE4")]
			[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x000123A8 File Offset: 0x000105A8
		// (set) Token: 0x06003BE6 RID: 15334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B4")]
		public bool IsFocused
		{
			[Token(Token = "0x6003BE5")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BE6")]
			[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B5")]
		public Collider FocusedCollider
		{
			[Token(Token = "0x6003BE7")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BE8")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B6")]
		public GameObject FocusedItemGO
		{
			[Token(Token = "0x6003BE9")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BEA")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BEB")]
		[Address(RVA = "0x3596C00", Offset = "0x3595200", VA = "0x183596C00")]
		public void SetTarget(GameObject go, bool cleanupTargetAfterSelect)
		{
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x000123C0 File Offset: 0x000105C0
		[Token(Token = "0x6003BEC")]
		[Address(RVA = "0x3596E10", Offset = "0x3595410", VA = "0x183596E10", Slot = "4")]
		public bool TryGetTargetScore(out float targetScore)
		{
			return default(bool);
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BED")]
		[Address(RVA = "0x3596E30", Offset = "0x3595430", VA = "0x183596E30", Slot = "5")]
		public void SelectTarget()
		{
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BEE")]
		[Address(RVA = "0x12C8170", Offset = "0x12C6770", VA = "0x1812C8170", Slot = "6")]
		public void DeselectTarget()
		{
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BEF")]
		[Address(RVA = "0x3596E50", Offset = "0x3595450", VA = "0x183596E50")]
		public GenericGrabberTargetProvider()
		{
		}
	}
}
