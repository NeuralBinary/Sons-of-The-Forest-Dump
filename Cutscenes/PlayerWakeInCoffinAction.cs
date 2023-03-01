using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Cutscenes
{
	// Token: 0x02000792 RID: 1938
	[Token(Token = "0x2000792")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeInCoffinAction")]
	public class PlayerWakeInCoffinAction : MonoBehaviour
	{
		// Token: 0x06003349 RID: 13129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003349")]
		[Address(RVA = "0x2E65700", Offset = "0x2E64700", VA = "0x182E65700")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334A")]
		[Address(RVA = "0x2E65990", Offset = "0x2E64990", VA = "0x182E65990")]
		public void TriggerDisablePost()
		{
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334B")]
		[Address(RVA = "0x2E658A0", Offset = "0x2E648A0", VA = "0x182E658A0")]
		public void StartAction(PlayerDeathCutsceneMarker marker, Animator animator, camFollowHead cameraFollow, Action<PlayerDeathCutsceneMarker> completedWakeup)
		{
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600334C")]
		[Address(RVA = "0x2E65A10", Offset = "0x2E64A10", VA = "0x182E65A10")]
		private IEnumerator Worker(PlayerDeathCutsceneMarker marker, Animator animator, camFollowHead cameraFollow, Action<PlayerDeathCutsceneMarker> completedWakeup)
		{
			return null;
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600334D")]
		[Address(RVA = "0x2E65690", Offset = "0x2E64690", VA = "0x182E65690")]
		private IEnumerator DoOutroStage()
		{
			return null;
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600334E")]
		[Address(RVA = "0x2E65620", Offset = "0x2E64620", VA = "0x182E65620")]
		private IEnumerator DoLighterStage()
		{
			return null;
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334F")]
		[Address(RVA = "0x2E65510", Offset = "0x2E64510", VA = "0x182E65510")]
		private void CreateAndPlaceDroppedInventoryBag(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003350")]
		[Address(RVA = "0x2E65810", Offset = "0x2E64810", VA = "0x182E65810")]
		private IEnumerator SetupCoffin(PlayerDeathCutsceneMarker marker)
		{
			return null;
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003351")]
		[Address(RVA = "0x2E65770", Offset = "0x2E64770", VA = "0x182E65770")]
		private IEnumerator InitializePlayer(Animator animator, camFollowHead cameraFollow)
		{
			return null;
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003352")]
		[Address(RVA = "0x2E64B70", Offset = "0x2E63B70", VA = "0x182E64B70")]
		public void CancelAction()
		{
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003353")]
		[Address(RVA = "0x2E64C00", Offset = "0x2E63C00", VA = "0x182E64C00")]
		private void Cleanup()
		{
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003354")]
		[Address(RVA = "0x2E65AE0", Offset = "0x2E64AE0", VA = "0x182E65AE0")]
		public PlayerWakeInCoffinAction()
		{
		}

		// Token: 0x04002C86 RID: 11398
		[Token(Token = "0x4002C86")]
		private const string CutsceneMarkerObjectName = "CoffinCutsceneMarker";

		// Token: 0x04002C87 RID: 11399
		[Token(Token = "0x4002C87")]
		[FieldOffset(Offset = "0x20")]
		public GameObject HeldLighterGo;

		// Token: 0x04002C88 RID: 11400
		[Token(Token = "0x4002C88")]
		[FieldOffset(Offset = "0x28")]
		public GameObject HeldLighterFlame;

		// Token: 0x04002C89 RID: 11401
		[Token(Token = "0x4002C89")]
		[FieldOffset(Offset = "0x30")]
		private GameObject _coffinGameObject;

		// Token: 0x04002C8A RID: 11402
		[Token(Token = "0x4002C8A")]
		[FieldOffset(Offset = "0x38")]
		private Volume _postEffectVolume;

		// Token: 0x04002C8B RID: 11403
		[Token(Token = "0x4002C8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _coffinSetupPrefab;

		// Token: 0x04002C8C RID: 11404
		[Token(Token = "0x4002C8C")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine _routine;

		// Token: 0x04002C8D RID: 11405
		[Token(Token = "0x4002C8D")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _lighterPrompt;

		// Token: 0x04002C8E RID: 11406
		[Token(Token = "0x4002C8E")]
		[FieldOffset(Offset = "0x58")]
		private GameObject _breakoutPrompt;

		// Token: 0x04002C8F RID: 11407
		[Token(Token = "0x4002C8F")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.InCoffin;

		// Token: 0x04002C90 RID: 11408
		[Token(Token = "0x4002C90")]
		[FieldOffset(Offset = "0x60")]
		private int _triggerCutsceneHash;
	}
}
