using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[Flags]
	public enum UiMessages
	{
		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		Unspecified = -3,
		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		Ignore = -2,
		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		None = 0,
		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		PrimaryCodeFilter = 255,
		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		Place = 2,
		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		PlaceOnGround = 3,
		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		Combine = 4,
		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		Cut = 5,
		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		Level = 6,
		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		Lift = 7,
		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		Above = 8,
		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		Equip = 9,
		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		Fire = 10,
		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		Beam = 11,
		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		Wall = 12,
		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		Pilar = 13,
		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		Strut = 14,
		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		Floor = 15,
		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		Stairs = 16,
		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		Ramp = 17,
		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		Post = 18,
		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		Fence = 19,
		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		Apex = 20,
		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		RockWall = 21,
		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		RockWallColumn = 22,
		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		RockWallAlternating = 23,
		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		Ladder = 24,
		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		Tarp = 25,
		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		TarpStake = 26,
		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		Door = 27,
		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		DefensiveWall = 28,
		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		DefensiveWallGate = 29,
		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		Reinforce = 30,
		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		Raft = 31,
		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		Support = 32,
		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		Hook = 33,
		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		Trap = 34,
		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		BridgeRope = 35,
		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		BridgeRopeNotAvailable = 36,
		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		BridgeFloor = 37,
		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		Stack = 38,
		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		ElectricWire = 39,
		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		PowerSource = 40,
		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		CollectElement = 41,
		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		CollectElement3D = 42,
		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		CollectElementAuthBlocked = 43,
		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		CollectElementStructurallyBlocked = 44,
		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		Damaged = 45,
		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		SecondaryCodeFilter = 65280,
		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		Cancel = 256,
		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		Mode = 512,
		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		ModifiersCodeFilter = 983040,
		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		NotAvailable = 65536,
		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		TertiaryCodeFilter = 267386880,
		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		Rotate = 1048576,
		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		PlaceAndCancel = 258,
		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		PlaceOnGroundAndCancel = 259,
		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		CutAndCancel = 261
	}
}
