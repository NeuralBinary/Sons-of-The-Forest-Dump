using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public class ImplicitPoint2d : ImplicitField2d
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x1FEFE00", Offset = "0x1FEE400", VA = "0x181FEFE00")]
		public ImplicitPoint2d(float x, float y)
		{
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x1FEFE20", Offset = "0x1FEE420", VA = "0x181FEFE20")]
		public ImplicitPoint2d(float x, float y, float radius)
		{
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0000737C File Offset: 0x0000557C
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x1FEFE30", Offset = "0x1FEE430", VA = "0x181FEFE30", Slot = "4")]
		public float Value(float fX, float fY)
		{
			return 0f;
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00007394 File Offset: 0x00005594
		[Token(Token = "0x170001B5")]
		public AxisAlignedBox2f Bounds
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x1FEFE80", Offset = "0x1FEE480", VA = "0x181FEFE80", Slot = "6")]
			get
			{
				return default(AxisAlignedBox2f);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x1FEFED0", Offset = "0x1FEE4D0", VA = "0x181FEFED0", Slot = "5")]
		public void Gradient(float fX, float fY, ref float fGX, ref float fGY)
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000073AC File Offset: 0x000055AC
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x1FEFFF0", Offset = "0x1FEE5F0", VA = "0x181FEFFF0")]
		public bool InBounds(float x, float y)
		{
			return default(bool);
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x000073C4 File Offset: 0x000055C4
		[Token(Token = "0x170001B6")]
		public float LowX
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x1FF0040", Offset = "0x1FEE640", VA = "0x181FF0040")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x000073DC File Offset: 0x000055DC
		[Token(Token = "0x170001B7")]
		public float LowY
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x1FF0050", Offset = "0x1FEE650", VA = "0x181FF0050")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x000073F4 File Offset: 0x000055F4
		[Token(Token = "0x170001B8")]
		public float HighX
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x1FF0060", Offset = "0x1FEE660", VA = "0x181FF0060")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0000740C File Offset: 0x0000560C
		[Token(Token = "0x170001B9")]
		public float HighY
		{
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x1FF0070", Offset = "0x1FEE670", VA = "0x181FF0070")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00007424 File Offset: 0x00005624
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BA")]
		public float radius
		{
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
			set
			{
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0000743C File Offset: 0x0000563C
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BB")]
		public float x
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
			set
			{
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00007454 File Offset: 0x00005654
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BC")]
		public float y
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
			set
			{
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0000746C File Offset: 0x0000566C
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BD")]
		public Vector2f Center
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x1B15E80", Offset = "0x1B14480", VA = "0x181B15E80")]
			get
			{
				return default(Vector2f);
			}
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x754960", Offset = "0x752F60", VA = "0x180754960")]
			set
			{
			}
		}

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x10")]
		private Vector2f m_vCenter;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x18")]
		private float m_radius;
	}
}
