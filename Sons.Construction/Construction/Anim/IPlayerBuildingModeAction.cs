using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002C2 RID: 706
	[Token(Token = "0x20002C2")]
	public interface IPlayerBuildingModeAction
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600154D RID: 5453
		[Token(Token = "0x17000475")]
		BuildActionAccessories Accessories { [Token(Token = "0x600154D")] get; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600154E RID: 5454
		[Token(Token = "0x17000476")]
		GameObject RightHandItemsRootX { [Token(Token = "0x600154E")] get; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600154F RID: 5455
		[Token(Token = "0x17000477")]
		GameObject HeldLogsVisOverrideX { [Token(Token = "0x600154F")] get; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001550 RID: 5456
		[Token(Token = "0x17000478")]
		IConstructionAnimationActor Actor { [Token(Token = "0x6001550")] get; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001551 RID: 5457
		[Token(Token = "0x17000479")]
		Action OnMoveCallback { [Token(Token = "0x6001551")] get; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001552 RID: 5458
		[Token(Token = "0x1700047A")]
		IConstructionModule RunningSequencerModule { [Token(Token = "0x6001552")] get; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001553 RID: 5459
		[Token(Token = "0x1700047B")]
		StructureElement RunningSequencerPrefab { [Token(Token = "0x6001553")] get; }

		// Token: 0x06001554 RID: 5460
		[Token(Token = "0x6001554")]
		void TriggerPartialPlace();

		// Token: 0x06001555 RID: 5461
		[Token(Token = "0x6001555")]
		void TriggerPlace();

		// Token: 0x06001556 RID: 5462
		[Token(Token = "0x6001556")]
		void UnregisterLayerActivators(ILayerBehaviourActivator[] layerActivators, ILayerBehaviourActivator[] layerDisablers);

		// Token: 0x06001557 RID: 5463
		[Token(Token = "0x6001557")]
		void CheckPerfectFinish();

		// Token: 0x06001558 RID: 5464
		[Token(Token = "0x6001558")]
		void MakeRightHeldRendererFinishPerfect(IIkSingleGoalProviderModule managerActiveModule, TargetInfo targetInfo, StructureElement elementPrefab, float ikDelay, float ikSmoothDuration);

		// Token: 0x06001559 RID: 5465
		[Token(Token = "0x6001559")]
		IEnumerator StashLeftHandItem(Action onStashedCallback);
	}
}
