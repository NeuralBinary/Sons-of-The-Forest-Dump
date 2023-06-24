using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public enum ConditionType
	{
		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		Stat,
		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		State,
		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		Inventory,
		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		Direction,
		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		Distance,
		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		MovementSpeed,
		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		RandomChance,
		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		IsInWater,
		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		IsNotInWater,
		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		StateTime,
		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		TimeOfDay,
		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		GroundDistance,
		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		NotSeason,
		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		BoundsDistance,
		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		NotAnimTag,
		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		NotAboveNavmesh,
		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		PlayerDistance,
		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		Equipped,
		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		NotTowardsGoal,
		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		InVillage,
		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		PassesByPlayer,
		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		InCave,
		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		PassesByMutant,
		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		IsAnimTag,
		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		NavmeshCastBlocked,
		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		HasOrders,
		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		VariationId,
		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		StimuliTimeAlive,
		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		NotInPlayerView,
		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		MemoryEvent,
		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		IsNotRaining,
		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		HasNoMeleeWeapon,
		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		IsNotFamily,
		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		IsCarryingObject,
		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		IsNotNearBush,
		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		ShouldFight,
		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		IsDismembered,
		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		RobbyInjured,
		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		CannibalAnger,
		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		CombatTime,
		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		PlayerDirection,
		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		IsNotStealth,
		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		BuildStage,
		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		NotHoldingNeededItems,
		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		NeedsItem,
		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		TargetLow,
		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		TargetNotLow,
		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		VerticalOffset,
		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		GroupSize,
		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		PlayerSentiment,
		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		IsSeason,
		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		DistanceXZ,
		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		NotHeavyAttack,
		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		OrderActiveTime,
		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		IsNotPerforming,
		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		IsFamily,
		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		IsNotOnSand,
		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		NoFighterWaiting,
		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		NotDyingOnBack,
		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		Health,
		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		CanNotSpawnActor
	}
}
