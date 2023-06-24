using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000225 RID: 549
	[Token(Token = "0x2000225")]
	[Serializable]
	public class PlaceStrutStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0000A304 File Offset: 0x00008504
		[Token(Token = "0x170003DA")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x60010B8")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0000A31C File Offset: 0x0000851C
		[Token(Token = "0x170003DB")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60010B9")]
			[Address(RVA = "0x22DA7E0", Offset = "0x22D8DE0", VA = "0x1822DA7E0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x2F14D90", Offset = "0x2F13390", VA = "0x182F14D90")]
		public PlaceStrutStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x2F14E10", Offset = "0x2F13410", VA = "0x182F14E10", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0000A334 File Offset: 0x00008534
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x2F15230", Offset = "0x2F13830", VA = "0x182F15230", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x2F153D0", Offset = "0x2F139D0", VA = "0x182F153D0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x2F15660", Offset = "0x2F13C60", VA = "0x182F15660")]
		private void SetupStrutFromBeam(TargetInfo targetInfo)
		{
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0000A34C File Offset: 0x0000854C
		[Token(Token = "0x60010BF")]
		[Address(RVA = "0x2F15BE0", Offset = "0x2F141E0", VA = "0x182F15BE0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0000A364 File Offset: 0x00008564
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x2F15C00", Offset = "0x2F14200", VA = "0x182F15C00")]
		private bool TryGetPredictedStrutSnapPointFromBeam(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0000A37C File Offset: 0x0000857C
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x2F167C0", Offset = "0x2F14DC0", VA = "0x182F167C0")]
		private Vector3 GetCustomTargetPos(TargetInfo targetInfo)
		{
			return default(Vector3);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x2F16C00", Offset = "0x2F15200", VA = "0x182F16C00")]
		[CompilerGenerated]
		internal static BeamDirections[] <TryGetPredictedStrutSnapPointFromBeam>g__GetValidStrutDirs|10_0(IBeamSupport backSupport, IBeamSupport forwardSupport, StructureElement beamElement)
		{
			return null;
		}

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly BeamDirections[] backDirOnly;

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BeamDirections[] forwardDirOnly;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BeamDirections[] BackAndForwardDirs;

		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x18")]
		private static readonly BeamDirections[] NoDir;
	}
}
