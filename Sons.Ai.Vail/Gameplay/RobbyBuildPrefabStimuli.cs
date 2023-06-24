using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class RobbyBuildPrefabStimuli : BuildActionStimuli
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2AEDAF0", Offset = "0x2AEC0F0", VA = "0x182AEDAF0")]
		public new static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2AEDB20", Offset = "0x2AEC120", VA = "0x182AEDB20")]
		public new static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2AEDBA0", Offset = "0x2AEC1A0", VA = "0x182AEDBA0", Slot = "8")]
		protected override void Awake()
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2AEDD00", Offset = "0x2AEC300", VA = "0x182AEDD00")]
		private void Update()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2AEDDE0", Offset = "0x2AEC3E0", VA = "0x182AEDDE0")]
		private void UpdateRequiredItem()
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2AEE090", Offset = "0x2AEC690", VA = "0x182AEE090", Slot = "29")]
		public override bool NeedsItemRobbyCantGet()
		{
			return default(bool);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2AEE120", Offset = "0x2AEC720", VA = "0x182AEE120", Slot = "27")]
		public override bool IsBuildable()
		{
			return default(bool);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2AEE1B0", Offset = "0x2AEC7B0", VA = "0x182AEE1B0", Slot = "28")]
		public override int NeedsItem(int itemId)
		{
			return 0;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2AEE1D0", Offset = "0x2AEC7D0", VA = "0x182AEE1D0")]
		private bool TryAddCarriedItem(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2AEE590", Offset = "0x2AECB90", VA = "0x182AEE590", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2AEE690", Offset = "0x2AECC90", VA = "0x182AEE690", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2AEE7C0", Offset = "0x2AECDC0", VA = "0x182AEE7C0")]
		private void TestBuild(int maxSteps = 1000)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public RobbyBuildPrefabStimuli()
		{
		}

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0xD0")]
		private MonoBehaviour _craftingComponent;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xD8")]
		private IVailCraftingNode _craftingNode;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0xE0")]
		private string _requiredItemType;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0xE8")]
		private int _requiredItemId;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0xEC")]
		private int _requiredItemCount;
	}
}
