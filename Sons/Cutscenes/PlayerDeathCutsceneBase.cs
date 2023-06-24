using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Endnight.Animation;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Areas;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x02000689 RID: 1673
	[Token(Token = "0x2000689")]
	public abstract class PlayerDeathCutsceneBase : MonoBehaviour
	{
		// Token: 0x06002BF3 RID: 11251
		[Token(Token = "0x6002BF3")]
		public abstract DeathCutsceneType GetCutsceneType();

		// Token: 0x06002BF4 RID: 11252
		[Token(Token = "0x6002BF4")]
		protected abstract int GetTriggerCutsceneHash();

		// Token: 0x06002BF5 RID: 11253
		[Token(Token = "0x6002BF5")]
		protected abstract int GetIntroHash();

		// Token: 0x06002BF6 RID: 11254
		[Token(Token = "0x6002BF6")]
		protected abstract int GetIdleHash();

		// Token: 0x06002BF7 RID: 11255
		[Token(Token = "0x6002BF7")]
		protected abstract int GetOutroHash();

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x3419310", Offset = "0x3417910", VA = "0x183419310", Slot = "9")]
		protected virtual PlayerDeathCutsceneMarker FindMarker(int markerHash)
		{
			return null;
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x0000CF48 File Offset: 0x0000B148
		[Token(Token = "0x170005CC")]
		public bool IsCoopPlayerProxy
		{
			[Token(Token = "0x6002BF9")]
			[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x671160", Offset = "0x66F760", VA = "0x180671160")]
		public void SetIsCoopMode(bool value)
		{
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x34194B0", Offset = "0x3417AB0", VA = "0x1834194B0")]
		public static void SetDeathCutsceneType(DeathCutsceneType type)
		{
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x0000CF60 File Offset: 0x0000B160
		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0x3419510", Offset = "0x3417B10", VA = "0x183419510")]
		public static DeathCutsceneType GetDeathCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BFD")]
		[Address(RVA = "0x3419650", Offset = "0x3417C50", VA = "0x183419650")]
		public void StartAction(PlayerDeathCutsceneMarker marker, Animator animator, camFollowHead cameraFollow, Action<PlayerDeathCutsceneMarker> completedWakeup)
		{
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0x34196D0", Offset = "0x3417CD0", VA = "0x1834196D0")]
		private IEnumerator Worker(PlayerDeathCutsceneMarker marker, Animator animator, camFollowHead cameraFollow, Action<PlayerDeathCutsceneMarker> completedWakeup)
		{
			return null;
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x34198E0", Offset = "0x3417EE0", VA = "0x1834198E0")]
		private IEnumerator WaitForIntroOrIdle(float delay, Animator animator)
		{
			return null;
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x3419A00", Offset = "0x3418000", VA = "0x183419A00")]
		private IEnumerator DoOutroPhase(Animator animator)
		{
			return null;
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x3419B00", Offset = "0x3418100", VA = "0x183419B00")]
		private IEnumerator DoCoopWaitForOutroAnimStart(Animator animator)
		{
			return null;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C02")]
		[Address(RVA = "0x3419C00", Offset = "0x3418200", VA = "0x183419C00")]
		private IEnumerator DoWaitForOutroAnimFinish(Animator animator)
		{
			return null;
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C03")]
		[Address(RVA = "0x3419D00", Offset = "0x3418300", VA = "0x183419D00")]
		private void ForceOutroAnimationState(Animator animator)
		{
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C04")]
		[Address(RVA = "0x3419E70", Offset = "0x3418470", VA = "0x183419E70")]
		private IEnumerator SetupCutscenePropsInternal(PlayerDeathCutsceneMarker marker, Animator animator)
		{
			return null;
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C05")]
		[Address(RVA = "0x3419F70", Offset = "0x3418570", VA = "0x183419F70")]
		private IEnumerator LinkCutscenePropsInternal(PlayerDeathCutsceneMarker marker, Animator animator)
		{
			return null;
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x341A0D0", Offset = "0x34186D0", VA = "0x18341A0D0")]
		private bool SetupBreakoutPrompt()
		{
			return default(bool);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x341A480", Offset = "0x3418A80", VA = "0x18341A480")]
		[Conditional("DEBUG_OPTIMIZATION_OFF")]
		private void Log(string message, [Optional] UnityEngine.Object context)
		{
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C08")]
		[Address(RVA = "0x341A4F0", Offset = "0x3418AF0", VA = "0x18341A4F0")]
		private void DiscoverSyncObjects(Animator animator)
		{
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C09")]
		[Address(RVA = "0x341A950", Offset = "0x3418F50", VA = "0x18341A950")]
		private static void SelectAndStartDeathCutscene(Animator animator, camFollowHead camFollowHead, PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0A")]
		[Address(RVA = "0x341AE90", Offset = "0x3419490", VA = "0x18341AE90")]
		private static void CompletedWakeup(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0B")]
		[Address(RVA = "0x341B010", Offset = "0x3419610", VA = "0x18341B010")]
		private static void SetTiedUpState(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0C")]
		[Address(RVA = "0x341B170", Offset = "0x3419770", VA = "0x18341B170")]
		private static void ClearTiedUpState()
		{
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x341B2C0", Offset = "0x34198C0", VA = "0x18341B2C0")]
		public static void SelectAndStartDeathCutscene(Animator animator, camFollowHead camFollowHead)
		{
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0E")]
		[Address(RVA = "0x341B380", Offset = "0x3419980", VA = "0x18341B380")]
		public static void SelectAndStartDeathCutsceneFromEvent(Animator animator, camFollowHead cameraFollow, DeathCutsceneType responseDeathCutsceneType, int responseMarkerHash)
		{
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0F")]
		[Address(RVA = "0x341B670", Offset = "0x3419C70", VA = "0x18341B670")]
		private static PlayerDeathCutsceneMarker FindMarkerWithHash(int responseMarkerHash)
		{
			return null;
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C10")]
		[Address(RVA = "0x341B8B0", Offset = "0x3419EB0", VA = "0x18341B8B0")]
		private static void SelectAndStartDeathCutsceneInternal(Animator animator, camFollowHead cameraFollow, DeathCutsceneType value, Vector3 sourcePosition)
		{
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Token(Token = "0x6002C11")]
		[Address(RVA = "0x341BCD0", Offset = "0x341A2D0", VA = "0x18341BCD0")]
		public static bool TryFindClosestMarker(Vector3 sourcePosition, DeathCutsceneType deathCutsceneType, out PlayerDeathCutsceneMarker result)
		{
			return default(bool);
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[Token(Token = "0x6002C12")]
		[Address(RVA = "0x341BD70", Offset = "0x341A370", VA = "0x18341BD70")]
		public static bool TryFindClosestMarker(Vector3 sourcePosition, DeathCutsceneType deathCutsceneType, AreaMask area, DeathMarkerGroupMask groupMask, bool onlyEnabled, out PlayerDeathCutsceneMarker result)
		{
			return default(bool);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C13")]
		[Address(RVA = "0x341BE30", Offset = "0x341A430", VA = "0x18341BE30")]
		private static List<DeathMarkerGroup> FindValidGroups(AreaMask area, DeathMarkerGroupMask groupMask, bool onlyEnabled = true)
		{
			return null;
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C14")]
		[Address(RVA = "0x341C0B0", Offset = "0x341A6B0", VA = "0x18341C0B0")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(DeathCutsceneType deathCutsceneType, Vector3 sourcePosition)
		{
			return null;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x6002C15")]
		[Address(RVA = "0x341C180", Offset = "0x341A780", VA = "0x18341C180")]
		public static bool FindClosestMarkerFrom(Vector3 sourcePosition, DeathCutsceneType deathCutsceneType, IEnumerable<DeathMarkerGroup> markerGroups, bool onlyEnabled, out PlayerDeathCutsceneMarker result)
		{
			return default(bool);
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x6002C16")]
		[Address(RVA = "0x341C540", Offset = "0x341AB40", VA = "0x18341C540")]
		public static bool FindClosestMarkerFrom(Vector3 sourcePosition, DeathCutsceneType deathCutsceneType, IEnumerable<PlayerDeathCutsceneMarker> markers, ref PlayerDeathCutsceneMarker selected, ref float distanceSqr)
		{
			return default(bool);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C17")]
		[Address(RVA = "0x341C980", Offset = "0x341AF80", VA = "0x18341C980")]
		public static PlayerDeathCutsceneMarker FindClosestDeathCutsceneMarker(Vector3 sourcePosition)
		{
			return null;
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[Token(Token = "0x6002C18")]
		[Address(RVA = "0x341CB30", Offset = "0x341B130", VA = "0x18341CB30")]
		public static bool FindClosestDeathCutsceneMarker(Vector3 sourcePosition, out PlayerDeathCutsceneMarker result)
		{
			return default(bool);
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x0000D008 File Offset: 0x0000B208
		[Token(Token = "0x6002C19")]
		[Address(RVA = "0x341CCC0", Offset = "0x341B2C0", VA = "0x18341CCC0")]
		public static DeathCutsceneType FindRandomDeathCutsceneMarkerType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1A")]
		[Address(RVA = "0x341CFB0", Offset = "0x341B5B0", VA = "0x18341CFB0", Slot = "10")]
		public virtual IEnumerator SetupUniqueCutsceneProps()
		{
			return null;
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0x341CFF0", Offset = "0x341B5F0", VA = "0x18341CFF0", Slot = "11")]
		public virtual IEnumerator InitializePlayer(Animator animator, camFollowHead cameraFollow, PlayerDeathCutsceneMarker playerDeathCutsceneMarker)
		{
			return null;
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x341D150", Offset = "0x341B750", VA = "0x18341D150")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x341D160", Offset = "0x341B760", VA = "0x18341D160")]
		public void CancelAction()
		{
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x341D310", Offset = "0x341B910", VA = "0x18341D310")]
		private void CleanupInternal()
		{
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		public virtual void Cleanup()
		{
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C20")]
		[Address(RVA = "0x341D460", Offset = "0x341BA60", VA = "0x18341D460")]
		public static void Register(DeathMarkerGroup markerGroup)
		{
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C21")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void RegisterHashes(DeathMarkerGroup markerGroup)
		{
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C22")]
		[Address(RVA = "0x341D580", Offset = "0x341BB80", VA = "0x18341D580")]
		public static void Unregister(DeathMarkerGroup markerGroup)
		{
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C23")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void UnregisterHashes(DeathMarkerGroup markerGroup)
		{
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x341D610", Offset = "0x341BC10", VA = "0x18341D610")]
		public static void SetDeathCutsceneMarker(PlayerDeathCutsceneMarker foundObject)
		{
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x341D6C0", Offset = "0x341BCC0", VA = "0x18341D6C0")]
		public void StartCoop(int markerHash, Animator animator, Action<PlayerDeathCutsceneMarker> completeAction)
		{
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x341D850", Offset = "0x341BE50", VA = "0x18341D850")]
		public static void CreateResponseFor(DeathMarkerRequest boltEvent)
		{
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x341D9B0", Offset = "0x341BFB0", VA = "0x18341D9B0")]
		private static void CreateResponseFor(DeathMarkerRequest boltEvent, DeathCutsceneType deathMarkerType, AreaMask boltEventAreaMask, DeathMarkerGroupMask boltEventGroupIdMask)
		{
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x0000D020 File Offset: 0x0000B220
		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x341DEE0", Offset = "0x341C4E0", VA = "0x18341DEE0")]
		private static bool TryGetBestDeathMarker(DeathMarkerRequest boltEvent, DeathCutsceneType deathMarkerType, AreaMask boltEventAreaMask, DeathMarkerGroupMask boltEventGroupIdMask, out PlayerDeathCutsceneMarker foundDeathMarker)
		{
			return default(bool);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x341E200", Offset = "0x341C800", VA = "0x18341E200")]
		private IEnumerator InitializeLocalPlayer(PlayerDeathCutsceneMarker marker)
		{
			return null;
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		internal virtual void PostPlayerSetup()
		{
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2B")]
		[Address(RVA = "0x341E300", Offset = "0x341C900", VA = "0x18341E300")]
		private IEnumerator SetupLocalPlayerProps(PlayerDeathCutsceneMarker marker)
		{
			return null;
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0x341E400", Offset = "0x341CA00", VA = "0x18341E400")]
		private void CreateAndPlaceDroppedInventoryBag(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0x341E590", Offset = "0x341CB90", VA = "0x18341E590")]
		private IEnumerator LocalPlayerWorker()
		{
			return null;
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0x341E620", Offset = "0x341CC20", VA = "0x18341E620")]
		private IEnumerator DoLocalPlayerOutroPhase(Animator animator)
		{
			return null;
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x341E720", Offset = "0x341CD20", VA = "0x18341E720")]
		private void CleanupLocalPlayer()
		{
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x0000D038 File Offset: 0x0000B238
		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x341EEE0", Offset = "0x341D4E0", VA = "0x18341EEE0")]
		public static AreaMask GetAreaMask()
		{
			return AreaMask.None;
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x6002C31")]
		[Address(RVA = "0x341F060", Offset = "0x341D660", VA = "0x18341F060")]
		public static DeathMarkerGroupMask GetGroupIdMask()
		{
			return DeathMarkerGroupMask.None;
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C32")]
		[Address(RVA = "0x341F1F0", Offset = "0x341D7F0", VA = "0x18341F1F0")]
		protected PlayerDeathCutsceneBase()
		{
		}

		// Token: 0x040026DB RID: 9947
		[Token(Token = "0x40026DB")]
		private const string DeathSetupBreakoutPromptString = "DeathSetupBreakoutPrompt";

		// Token: 0x040026DC RID: 9948
		[Token(Token = "0x40026DC")]
		private const string PlayerAnimatorSyncString = "PlayerAnimatorSync";

		// Token: 0x040026DD RID: 9949
		[Token(Token = "0x40026DD")]
		private const string PlayerLocatorPromptString = "PlayerLocator";

		// Token: 0x040026DE RID: 9950
		[Token(Token = "0x40026DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_coffinSetupPrefab")]
		[SerializeField]
		private GameObject _cutsceneStagePrefab;

		// Token: 0x040026DF RID: 9951
		[Token(Token = "0x40026DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected AnimationEventReceiver _animationEventReceiver;

		// Token: 0x040026E0 RID: 9952
		[Token(Token = "0x40026E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _mouseRotatorLimit;

		// Token: 0x040026E1 RID: 9953
		[Token(Token = "0x40026E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _playerLocator;

		// Token: 0x040026E2 RID: 9954
		[Token(Token = "0x40026E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _routine;

		// Token: 0x040026E3 RID: 9955
		[Token(Token = "0x40026E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly int _cutsceneStageHash;

		// Token: 0x040026E4 RID: 9956
		[Token(Token = "0x40026E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject _cutsceneStageGameObject;

		// Token: 0x040026E5 RID: 9957
		[Token(Token = "0x40026E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject _breakoutPrompt;

		// Token: 0x040026E6 RID: 9958
		[Token(Token = "0x40026E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<DeathMarkerGroup> _registeredMarkerGroups;

		// Token: 0x040026E7 RID: 9959
		[Token(Token = "0x40026E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DeathCutsceneType _defaultDeathCutsceneType;

		// Token: 0x040026E8 RID: 9960
		[Token(Token = "0x40026E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static DeathCutsceneType _deathCutsceneType;

		// Token: 0x040026E9 RID: 9961
		[Token(Token = "0x40026E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject _playerAnimatorSyncHolder;

		// Token: 0x040026EA RID: 9962
		[Token(Token = "0x40026EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AnimationSync[] _playerAnimatorSyncObjects;

		// Token: 0x040026EB RID: 9963
		[Token(Token = "0x40026EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static PlayerDeathCutsceneMarker _overrideDeathCutsceneMarker;

		// Token: 0x040026EC RID: 9964
		[Token(Token = "0x40026EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _isCoopPlayerProxy;

		// Token: 0x040026ED RID: 9965
		[Token(Token = "0x40026ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private camFollowHead _cameraFollowHead;

		// Token: 0x040026EE RID: 9966
		[Token(Token = "0x40026EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _loggingEnabled;

		// Token: 0x040026EF RID: 9967
		[Token(Token = "0x40026EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool _failed;

		// Token: 0x040026F0 RID: 9968
		[Token(Token = "0x40026F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<int, PlayerDeathCutsceneMarker> _markerHashDictionary;
	}
}
