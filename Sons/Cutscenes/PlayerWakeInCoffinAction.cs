using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Cutscenes
{
	// Token: 0x0200069D RID: 1693
	[Token(Token = "0x200069D")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeInCoffinAction")]
	public class PlayerWakeInCoffinAction : MonoBehaviour
	{
		// Token: 0x06002CC1 RID: 11457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC1")]
		[Address(RVA = "0x3429E70", Offset = "0x3428470", VA = "0x183429E70")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC2")]
		[Address(RVA = "0x3429EE0", Offset = "0x34284E0", VA = "0x183429EE0")]
		public void TriggerDisablePost()
		{
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC3")]
		[Address(RVA = "0x3429FF0", Offset = "0x34285F0", VA = "0x183429FF0")]
		public void StartAction(PlayerDeathCutsceneMarker marker, Animator animator, camFollowHead cameraFollow, Action<PlayerDeathCutsceneMarker> completedWakeup)
		{
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC4")]
		[Address(RVA = "0x342A070", Offset = "0x3428670", VA = "0x18342A070")]
		private IEnumerator Worker(PlayerDeathCutsceneMarker marker, Animator animator, camFollowHead cameraFollow, Action<PlayerDeathCutsceneMarker> completedWakeup)
		{
			return null;
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC5")]
		[Address(RVA = "0x342A280", Offset = "0x3428880", VA = "0x18342A280")]
		private IEnumerator DoOutroStage()
		{
			return null;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x342A310", Offset = "0x3428910", VA = "0x18342A310")]
		private IEnumerator DoLighterStage()
		{
			return null;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x342A3A0", Offset = "0x34289A0", VA = "0x18342A3A0")]
		private void CreateAndPlaceDroppedInventoryBag(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x342A530", Offset = "0x3428B30", VA = "0x18342A530")]
		private IEnumerator SetupCoffin(PlayerDeathCutsceneMarker marker)
		{
			return null;
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC9")]
		[Address(RVA = "0x342A630", Offset = "0x3428C30", VA = "0x18342A630")]
		private IEnumerator InitializePlayer(Animator animator, camFollowHead cameraFollow)
		{
			return null;
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCA")]
		[Address(RVA = "0x342A790", Offset = "0x3428D90", VA = "0x18342A790")]
		public void CancelAction()
		{
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x342A880", Offset = "0x3428E80", VA = "0x18342A880")]
		private void Cleanup()
		{
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCC")]
		[Address(RVA = "0x342B560", Offset = "0x3429B60", VA = "0x18342B560")]
		public PlayerWakeInCoffinAction()
		{
		}

		// Token: 0x04002759 RID: 10073
		[Token(Token = "0x4002759")]
		private const string CutsceneMarkerObjectName = "CoffinCutsceneMarker";

		// Token: 0x0400275A RID: 10074
		[Token(Token = "0x400275A")]
		[FieldOffset(Offset = "0x20")]
		public GameObject HeldLighterGo;

		// Token: 0x0400275B RID: 10075
		[Token(Token = "0x400275B")]
		[FieldOffset(Offset = "0x28")]
		public GameObject HeldLighterFlame;

		// Token: 0x0400275C RID: 10076
		[Token(Token = "0x400275C")]
		[FieldOffset(Offset = "0x30")]
		private GameObject _coffinGameObject;

		// Token: 0x0400275D RID: 10077
		[Token(Token = "0x400275D")]
		[FieldOffset(Offset = "0x38")]
		private Volume _postEffectVolume;

		// Token: 0x0400275E RID: 10078
		[Token(Token = "0x400275E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _coffinSetupPrefab;

		// Token: 0x0400275F RID: 10079
		[Token(Token = "0x400275F")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine _routine;

		// Token: 0x04002760 RID: 10080
		[Token(Token = "0x4002760")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _lighterPrompt;

		// Token: 0x04002761 RID: 10081
		[Token(Token = "0x4002761")]
		[FieldOffset(Offset = "0x58")]
		private GameObject _breakoutPrompt;

		// Token: 0x04002762 RID: 10082
		[Token(Token = "0x4002762")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.InCoffin;

		// Token: 0x04002763 RID: 10083
		[Token(Token = "0x4002763")]
		[FieldOffset(Offset = "0x60")]
		private int _triggerCutsceneHash;
	}
}
