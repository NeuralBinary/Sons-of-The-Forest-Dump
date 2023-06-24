using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000231 RID: 561
	[Token(Token = "0x2000231")]
	[Serializable]
	public class PlacePresetTarpOnPilarsModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x0000A73C File Offset: 0x0000893C
		[Token(Token = "0x170003EC")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6001113")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x0000A754 File Offset: 0x00008954
		[Token(Token = "0x170003ED")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6001114")]
			[Address(RVA = "0xE59CE0", Offset = "0xE582E0", VA = "0x180E59CE0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001115")]
		[Address(RVA = "0x2F1DAA0", Offset = "0x2F1C0A0", VA = "0x182F1DAA0")]
		public PlacePresetTarpOnPilarsModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001116")]
		[Address(RVA = "0x2F1DB20", Offset = "0x2F1C120", VA = "0x182F1DB20", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0000A76C File Offset: 0x0000896C
		[Token(Token = "0x6001117")]
		[Address(RVA = "0x2F1E130", Offset = "0x2F1C730", VA = "0x182F1E130", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001118")]
		[Address(RVA = "0x2F1E480", Offset = "0x2F1CA80", VA = "0x182F1E480", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x2F1E5E0", Offset = "0x2F1CBE0", VA = "0x182F1E5E0")]
		private void SetupTarp(TargetInfo targetInfo, out int quarters)
		{
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0000A784 File Offset: 0x00008984
		[Token(Token = "0x600111A")]
		[Address(RVA = "0x2F1E830", Offset = "0x2F1CE30", VA = "0x182F1E830")]
		private static Directions CalcStructureDir(IFloorSupport fs, Vector3 tarpPos)
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0000A79C File Offset: 0x0000899C
		[Token(Token = "0x600111B")]
		[Address(RVA = "0x2F1E910", Offset = "0x2F1CF10", VA = "0x182F1E910")]
		private static int CalcQuartersDiff(float support1Height, float supportHeight)
		{
			return 0;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x2F1E970", Offset = "0x2F1CF70", VA = "0x182F1E970")]
		public static void ProcessOrientationFromSupportHeight(TargetInfo targetInfo, out int quarters)
		{
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0000A7B4 File Offset: 0x000089B4
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x2F1EB70", Offset = "0x2F1D170", VA = "0x182F1EB70", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0000A7CC File Offset: 0x000089CC
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x2F1EB90", Offset = "0x2F1D190", VA = "0x182F1EB90")]
		private bool TryGetTarpPredictedSnapPointFromBeam(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x2F1F680", Offset = "0x2F1DC80", VA = "0x182F1F680")]
		[CompilerGenerated]
		internal static void <SetupTarp>g__LinkWithSupport|8_0(Directions tarpDir, BeamStructure beam, ref PlacePresetTarpOnPilarsModule.<>c__DisplayClass8_0 A_2)
		{
		}

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] PresetTarpDirs;
	}
}
