using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005B RID: 91
[Token(Token = "0x200005B")]
internal class GolfCartState : NetworkState, IGolfCartState, IState, IDisposable
{
	// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x7D5E50", Offset = "0x7D4450", VA = "0x1807D5E50")]
	public GolfCartState()
	{
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06000333 RID: 819 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001A6")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "31")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x06000334 RID: 820 RVA: 0x00003210 File Offset: 0x00001410
	// (set) Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001A7")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x7D5EB0", Offset = "0x7D44B0", VA = "0x1807D5EB0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x7D5F30", Offset = "0x7D4530", VA = "0x1807D5F30", Slot = "33")]
		set
		{
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000336 RID: 822 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001A8")]
	public NetworkTransform FrontLeftWheel
	{
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x7D60D0", Offset = "0x7D46D0", VA = "0x1807D60D0", Slot = "34")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000337 RID: 823 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001A9")]
	public NetworkTransform FrontRightWheel
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x7D6130", Offset = "0x7D4730", VA = "0x1807D6130", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000338 RID: 824 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001AA")]
	public NetworkTransform BackLeftWheel
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x7D6190", Offset = "0x7D4790", VA = "0x1807D6190", Slot = "36")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000339 RID: 825 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001AB")]
	public NetworkTransform BackRightWheel
	{
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x7D61F0", Offset = "0x7D47F0", VA = "0x1807D61F0", Slot = "37")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x0600033A RID: 826 RVA: 0x00003228 File Offset: 0x00001428
	// (set) Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001AC")]
	public float SteeringWheelRotation
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x7C3FF0", Offset = "0x7C25F0", VA = "0x1807C3FF0", Slot = "38")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x7D6250", Offset = "0x7D4850", VA = "0x1807D6250", Slot = "39")]
		set
		{
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x0600033C RID: 828 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001AD")]
	public NetworkArray_Entity ConnectedSlots
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x7D6360", Offset = "0x7D4960", VA = "0x1807D6360", Slot = "40")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x0600033D RID: 829 RVA: 0x00003240 File Offset: 0x00001440
	// (set) Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001AE")]
	public float FrontLeftWheelRpm
	{
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x7D6420", Offset = "0x7D4A20", VA = "0x1807D6420", Slot = "41")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x7D6480", Offset = "0x7D4A80", VA = "0x1807D6480", Slot = "42")]
		set
		{
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x0600033F RID: 831 RVA: 0x00003258 File Offset: 0x00001458
	// (set) Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001AF")]
	public float FrontRightWheelRpm
	{
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x7D6590", Offset = "0x7D4B90", VA = "0x1807D6590", Slot = "43")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x7D65F0", Offset = "0x7D4BF0", VA = "0x1807D65F0", Slot = "44")]
		set
		{
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000341 RID: 833 RVA: 0x00003270 File Offset: 0x00001470
	// (set) Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001B0")]
	public float BackLeftWheelRpm
	{
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x7D6700", Offset = "0x7D4D00", VA = "0x1807D6700", Slot = "45")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x7D6760", Offset = "0x7D4D60", VA = "0x1807D6760", Slot = "46")]
		set
		{
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000343 RID: 835 RVA: 0x00003288 File Offset: 0x00001488
	// (set) Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001B1")]
	public float BackRightRpm
	{
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x7D6870", Offset = "0x7D4E70", VA = "0x1807D6870", Slot = "47")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x7D68D0", Offset = "0x7D4ED0", VA = "0x1807D68D0", Slot = "48")]
		set
		{
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000345 RID: 837 RVA: 0x000032A0 File Offset: 0x000014A0
	// (set) Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001B2")]
	public float Power
	{
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x7D69E0", Offset = "0x7D4FE0", VA = "0x1807D69E0", Slot = "49")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x7D6A40", Offset = "0x7D5040", VA = "0x1807D6A40", Slot = "50")]
		set
		{
		}
	}
}
