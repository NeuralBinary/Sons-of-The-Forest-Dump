using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	[AddComponentMenu("Sons/Stimuli/Build Action Stimuli")]
	public class BuildActionStimuli : RobbyOrderStimuliBase
	{
		// Token: 0x06000DC2 RID: 3522 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x2BA68F0", Offset = "0x2BA4EF0", VA = "0x182BA68F0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x2BA6920", Offset = "0x2BA4F20", VA = "0x182BA6920")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x2739910", Offset = "0x2737F10", VA = "0x182739910")]
		public bool IsBuilt()
		{
			return default(bool);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x2BA69A0", Offset = "0x2BA4FA0", VA = "0x182BA69A0")]
		public void SetIsBuilt(bool value)
		{
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0xAFF420", Offset = "0xAFDA20", VA = "0x180AFF420", Slot = "23")]
		public override int GetBuildStage()
		{
			return 0;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x2BA69B0", Offset = "0x2BA4FB0", VA = "0x182BA69B0", Slot = "27")]
		public virtual bool IsBuildable()
		{
			return default(bool);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x2BA69C0", Offset = "0x2BA4FC0", VA = "0x182BA69C0", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "28")]
		public virtual int NeedsItem(int itemId)
		{
			return 0;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "29")]
		public virtual bool NeedsItemRobbyCantGet()
		{
			return default(bool);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x2BA6BF0", Offset = "0x2BA51F0", VA = "0x182BA6BF0")]
		private void DoBuildStage(BuildActionStimuli.BuildStage stage, VailActor actor)
		{
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x2BA6FC0", Offset = "0x2BA55C0", VA = "0x182BA6FC0")]
		private void DoConstructionBuild(BuildActionStimuli.BuildActionType buildAction, Vector3 actorPos, VailActor actor)
		{
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x2BA75F0", Offset = "0x2BA5BF0", VA = "0x182BA75F0")]
		private void RunConstruction()
		{
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public BuildActionStimuli()
		{
		}

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<BuildActionStimuli.BuildStage> _buildStages;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0xB8")]
		private bool _isBuilt;

		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject _targetTarp;

		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		[FieldOffset(Offset = "0xC8")]
		private int _stage;

		// Token: 0x020001D2 RID: 466
		[Token(Token = "0x20001D2")]
		[Serializable]
		private class BuildStage
		{
			// Token: 0x06000DCF RID: 3535 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public BuildStage()
			{
			}

			// Token: 0x040008C9 RID: 2249
			[Token(Token = "0x40008C9")]
			[FieldOffset(Offset = "0x10")]
			public string _name;

			// Token: 0x040008CA RID: 2250
			[Token(Token = "0x40008CA")]
			[FieldOffset(Offset = "0x18")]
			public bool _removeCarry;

			// Token: 0x040008CB RID: 2251
			[Token(Token = "0x40008CB")]
			[FieldOffset(Offset = "0x1C")]
			public BuildActionStimuli.BuildActionType _buildType;

			// Token: 0x040008CC RID: 2252
			[Token(Token = "0x40008CC")]
			[FieldOffset(Offset = "0x20")]
			public bool _buildComplete;

			// Token: 0x040008CD RID: 2253
			[Token(Token = "0x40008CD")]
			[FieldOffset(Offset = "0x28")]
			public List<GameObject> _showObjects;

			// Token: 0x040008CE RID: 2254
			[Token(Token = "0x40008CE")]
			[FieldOffset(Offset = "0x30")]
			public List<GameObject> _hideObjects;
		}

		// Token: 0x020001D3 RID: 467
		[Token(Token = "0x20001D3")]
		private enum BuildActionType
		{
			// Token: 0x040008D0 RID: 2256
			[Token(Token = "0x40008D0")]
			None,
			// Token: 0x040008D1 RID: 2257
			[Token(Token = "0x40008D1")]
			Fire,
			// Token: 0x040008D2 RID: 2258
			[Token(Token = "0x40008D2")]
			Tarp,
			// Token: 0x040008D3 RID: 2259
			[Token(Token = "0x40008D3")]
			Stake
		}
	}
}
