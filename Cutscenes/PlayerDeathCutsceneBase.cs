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
	// Token: 0x0200077E RID: 1918
	[Token(Token = "0x200077E")]
	public abstract class PlayerDeathCutsceneBase : MonoBehaviour
	{
		// Token: 0x0600327C RID: 12924
		[Token(Token = "0x600327C")]
		public abstract DeathCutsceneType GetCutsceneType();

		// Token: 0x0600327D RID: 12925
		[Token(Token = "0x600327D")]
		protected abstract int GetTriggerCutsceneHash();

		// Token: 0x0600327E RID: 12926
		[Token(Token = "0x600327E")]
		protected abstract int GetIntroHash();

		// Token: 0x0600327F RID: 12927
		[Token(Token = "0x600327F")]
		protected abstract int GetIdleHash();

		// Token: 0x06003280 RID: 12928
		[Token(Token = "0x6003280")]
		protected abstract int GetOutroHash();

		// Token: 0x06003281 RID: 12929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003281")]
		[Address(RVA = "0x2E4ED80", Offset = "0x2E4DD80", VA = "0x182E4ED80", Slot = "9")]
		protected virtual PlayerDeathCutsceneMarker FindMarker(int markerHash)
		{
			return null;
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x0000E670 File Offset: 0x0000C870
		[Token(Token = "0x1700065F")]
		public bool IsCoopPlayerProxy
		{
			[Token(Token = "0x6003282")]
			[Address(RVA = "0x5F0C80", Offset = "0x5EFC80", VA = "0x1805F0C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003283")]
		[Address(RVA = "0x5F0C90", Offset = "0x5EFC90", VA = "0x1805F0C90")]
		public void SetIsCoopMode(bool value)
		{
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003284")]
		[Address(RVA = "0x2E505D0", Offset = "0x2E4F5D0", VA = "0x182E505D0")]
		public static void SetDeathCutsceneType(DeathCutsceneType type)
		{
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x0000E688 File Offset: 0x0000C888
		[Token(Token = "0x6003285")]
		[Address(RVA = "0x2E4F470", Offset = "0x2E4E470", VA = "0x182E4F470")]
		public static DeathCutsceneType GetDeathCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003286")]
		[Address(RVA = "0x2E50A20", Offset = "0x2E4FA20", VA = "0x182E50A20")]
		public void StartAction(PlayerDeathCutsceneMarker marker, Animator animator, camFollowHead cameraFollow, Action<PlayerDeathCutsceneMarker> completedWakeup)
		{
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003287")]
		[Address(RVA = "0x2E511A0", Offset = "0x2E501A0", VA = "0x182E511A0")]
		private IEnumerator Worker(PlayerDeathCutsceneMarker marker, Animator animator, camFollowHead cameraFollow, Action<PlayerDeathCutsceneMarker> completedWakeup)
		{
			return null;
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003288")]
		[Address(RVA = "0x2E51100", Offset = "0x2E50100", VA = "0x182E51100")]
		private IEnumerator WaitForIntroOrIdle(float delay, Animator animator)
		{
			return null;
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003289")]
		[Address(RVA = "0x2E4E160", Offset = "0x2E4D160", VA = "0x182E4E160")]
		private IEnumerator DoOutroPhase(Animator animator)
		{
			return null;
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328A")]
		[Address(RVA = "0x2E4E040", Offset = "0x2E4D040", VA = "0x182E4E040")]
		private IEnumerator DoCoopWaitForOutroAnimStart(Animator animator)
		{
			return null;
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328B")]
		[Address(RVA = "0x2E4E1F0", Offset = "0x2E4D1F0", VA = "0x182E4E1F0")]
		private IEnumerator DoWaitForOutroAnimFinish(Animator animator)
		{
			return null;
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328C")]
		[Address(RVA = "0x2E4F1D0", Offset = "0x2E4E1D0", VA = "0x182E4F1D0")]
		private void ForceOutroAnimationState(Animator animator)
		{
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328D")]
		[Address(RVA = "0x2E508B0", Offset = "0x2E4F8B0", VA = "0x182E508B0")]
		private IEnumerator SetupCutscenePropsInternal(PlayerDeathCutsceneMarker marker, Animator animator)
		{
			return null;
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328E")]
		[Address(RVA = "0x2E4F800", Offset = "0x2E4E800", VA = "0x182E4F800")]
		private IEnumerator LinkCutscenePropsInternal(PlayerDeathCutsceneMarker marker, Animator animator)
		{
			return null;
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		[Token(Token = "0x600328F")]
		[Address(RVA = "0x2E50730", Offset = "0x2E4F730", VA = "0x182E50730")]
		private bool SetupBreakoutPrompt()
		{
			return default(bool);
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003290")]
		[Address(RVA = "0x2E4F920", Offset = "0x2E4E920", VA = "0x182E4F920")]
		[Conditional("DEBUG_OPTIMIZATION_OFF")]
		private void Log(string message, [Optional] Object context)
		{
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003291")]
		[Address(RVA = "0x2E4DEA0", Offset = "0x2E4CEA0", VA = "0x182E4DEA0")]
		private void DiscoverSyncObjects(Animator animator)
		{
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003292")]
		[Address(RVA = "0x2E50110", Offset = "0x2E4F110", VA = "0x182E50110")]
		private static void SelectAndStartDeathCutscene(Animator animator, camFollowHead camFollowHead, PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003293")]
		[Address(RVA = "0x2E4D960", Offset = "0x2E4C960", VA = "0x182E4D960")]
		private static void CompletedWakeup(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003294")]
		[Address(RVA = "0x2E50630", Offset = "0x2E4F630", VA = "0x182E50630")]
		private static void SetTiedUpState(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003295")]
		[Address(RVA = "0x2E4D870", Offset = "0x2E4C870", VA = "0x182E4D870")]
		private static void ClearTiedUpState()
		{
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003296")]
		[Address(RVA = "0x2E504A0", Offset = "0x2E4F4A0", VA = "0x182E504A0")]
		public static void SelectAndStartDeathCutscene(Animator animator, camFollowHead camFollowHead)
		{
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003297")]
		[Address(RVA = "0x2E4FA50", Offset = "0x2E4EA50", VA = "0x182E4FA50")]
		public static void SelectAndStartDeathCutsceneFromEvent(Animator animator, camFollowHead cameraFollow, DeathCutsceneType responseDeathCutsceneType, int responseMarkerHash)
		{
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003298")]
		[Address(RVA = "0x2E4EBC0", Offset = "0x2E4DBC0", VA = "0x182E4EBC0")]
		private static PlayerDeathCutsceneMarker FindMarkerWithHash(int responseMarkerHash)
		{
			return null;
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003299")]
		[Address(RVA = "0x2E4FD00", Offset = "0x2E4ED00", VA = "0x182E4FD00")]
		private static void SelectAndStartDeathCutsceneInternal(Animator animator, camFollowHead cameraFollow, DeathCutsceneType value, Vector3 sourcePosition)
		{
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x2E50C50", Offset = "0x2E4FC50", VA = "0x182E50C50")]
		public static bool TryFindClosestMarker(Vector3 sourcePosition, DeathCutsceneType deathCutsceneType, out PlayerDeathCutsceneMarker result)
		{
			return default(bool);
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		[Token(Token = "0x600329B")]
		[Address(RVA = "0x2E50CF0", Offset = "0x2E4FCF0", VA = "0x182E50CF0")]
		public static bool TryFindClosestMarker(Vector3 sourcePosition, DeathCutsceneType deathCutsceneType, AreaMask area, DeathMarkerGroupMask groupMask, bool onlyEnabled, out PlayerDeathCutsceneMarker result)
		{
			return default(bool);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329C")]
		[Address(RVA = "0x2E4EFD0", Offset = "0x2E4DFD0", VA = "0x182E4EFD0")]
		private static List<DeathMarkerGroup> FindValidGroups(AreaMask area, DeathMarkerGroupMask groupMask, bool onlyEnabled = true)
		{
			return null;
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329D")]
		[Address(RVA = "0x2E4EAF0", Offset = "0x2E4DAF0", VA = "0x182E4EAF0")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(DeathCutsceneType deathCutsceneType, Vector3 sourcePosition)
		{
			return null;
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		[Token(Token = "0x600329E")]
		[Address(RVA = "0x2E4E810", Offset = "0x2E4D810", VA = "0x182E4E810")]
		public static bool FindClosestMarkerFrom(Vector3 sourcePosition, DeathCutsceneType deathCutsceneType, IEnumerable<DeathMarkerGroup> markerGroups, bool onlyEnabled, out PlayerDeathCutsceneMarker result)
		{
			return default(bool);
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x0000E700 File Offset: 0x0000C900
		[Token(Token = "0x600329F")]
		[Address(RVA = "0x2E4E4A0", Offset = "0x2E4D4A0", VA = "0x182E4E4A0")]
		public static bool FindClosestMarkerFrom(Vector3 sourcePosition, DeathCutsceneType deathCutsceneType, IEnumerable<PlayerDeathCutsceneMarker> markers, ref PlayerDeathCutsceneMarker selected, ref float distanceSqr)
		{
			return default(bool);
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x2E4E280", Offset = "0x2E4D280", VA = "0x182E4E280")]
		public static PlayerDeathCutsceneMarker FindClosestDeathCutsceneMarker(Vector3 sourcePosition)
		{
			return null;
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x0000E718 File Offset: 0x0000C918
		[Token(Token = "0x60032A1")]
		[Address(RVA = "0x2E4E3A0", Offset = "0x2E4D3A0", VA = "0x182E4E3A0")]
		public static bool FindClosestDeathCutsceneMarker(Vector3 sourcePosition, out PlayerDeathCutsceneMarker result)
		{
			return default(bool);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x0000E730 File Offset: 0x0000C930
		[Token(Token = "0x60032A2")]
		[Address(RVA = "0x2E4EF00", Offset = "0x2E4DF00", VA = "0x182E4EF00")]
		public static DeathCutsceneType FindRandomDeathCutsceneMarkerType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A3")]
		[Address(RVA = "0x2E509D0", Offset = "0x2E4F9D0", VA = "0x182E509D0", Slot = "10")]
		public virtual IEnumerator SetupUniqueCutsceneProps()
		{
			return null;
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A4")]
		[Address(RVA = "0x2E4F750", Offset = "0x2E4E750", VA = "0x182E4F750", Slot = "11")]
		public virtual IEnumerator InitializePlayer(Animator animator, camFollowHead cameraFollow, PlayerDeathCutsceneMarker playerDeathCutsceneMarker)
		{
			return null;
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A5")]
		[Address(RVA = "0x2E4CE40", Offset = "0x2E4BE40", VA = "0x182E4CE40")]
		public void CancelAction()
		{
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x2E4CFF0", Offset = "0x2E4BFF0", VA = "0x182E4CFF0")]
		private void CleanupInternal()
		{
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A7")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "12")]
		public virtual void Cleanup()
		{
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A8")]
		[Address(RVA = "0x2E4F990", Offset = "0x2E4E990", VA = "0x182E4F990")]
		public static void Register(DeathMarkerGroup markerGroup)
		{
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A9")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private static void RegisterHashes(DeathMarkerGroup markerGroup)
		{
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AA")]
		[Address(RVA = "0x2E51070", Offset = "0x2E50070", VA = "0x182E51070")]
		public static void Unregister(DeathMarkerGroup markerGroup)
		{
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AB")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private static void UnregisterHashes(DeathMarkerGroup markerGroup)
		{
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AC")]
		[Address(RVA = "0x2E50560", Offset = "0x2E4F560", VA = "0x182E50560")]
		public static void SetDeathCutsceneMarker(PlayerDeathCutsceneMarker foundObject)
		{
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AD")]
		[Address(RVA = "0x2E50B20", Offset = "0x2E4FB20", VA = "0x182E50B20")]
		public void StartCoop(int markerHash, Animator animator, Action<PlayerDeathCutsceneMarker> completeAction)
		{
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AE")]
		[Address(RVA = "0x2E4DB90", Offset = "0x2E4CB90", VA = "0x182E4DB90")]
		public static void CreateResponseFor(DeathMarkerRequest boltEvent)
		{
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AF")]
		[Address(RVA = "0x2E4DC40", Offset = "0x2E4CC40", VA = "0x182E4DC40")]
		private static void CreateResponseFor(DeathMarkerRequest boltEvent, DeathCutsceneType deathMarkerType, AreaMask boltEventAreaMask, DeathMarkerGroupMask boltEventGroupIdMask)
		{
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x60032B0")]
		[Address(RVA = "0x2E50DB0", Offset = "0x2E4FDB0", VA = "0x182E50DB0")]
		private static bool TryGetBestDeathMarker(DeathMarkerRequest boltEvent, DeathCutsceneType deathMarkerType, AreaMask boltEventAreaMask, DeathMarkerGroupMask boltEventGroupIdMask, out PlayerDeathCutsceneMarker foundDeathMarker)
		{
			return default(bool);
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B1")]
		[Address(RVA = "0x2E4F6C0", Offset = "0x2E4E6C0", VA = "0x182E4F6C0")]
		private IEnumerator InitializeLocalPlayer(PlayerDeathCutsceneMarker marker)
		{
			return null;
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B2")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "13")]
		internal virtual void PostPlayerSetup()
		{
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x2E50940", Offset = "0x2E4F940", VA = "0x182E50940")]
		private IEnumerator SetupLocalPlayerProps(PlayerDeathCutsceneMarker marker)
		{
			return null;
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B4")]
		[Address(RVA = "0x2E4DA80", Offset = "0x2E4CA80", VA = "0x182E4DA80")]
		private void CreateAndPlaceDroppedInventoryBag(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B5")]
		[Address(RVA = "0x2E4F8B0", Offset = "0x2E4E8B0", VA = "0x182E4F8B0")]
		private IEnumerator LocalPlayerWorker()
		{
			return null;
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B6")]
		[Address(RVA = "0x2E4E0D0", Offset = "0x2E4D0D0", VA = "0x182E4E0D0")]
		private IEnumerator DoLocalPlayerOutroPhase(Animator animator)
		{
			return null;
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B7")]
		[Address(RVA = "0x2E4D060", Offset = "0x2E4C060", VA = "0x182E4D060")]
		private void CleanupLocalPlayer()
		{
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x60032B8")]
		[Address(RVA = "0x2E4F310", Offset = "0x2E4E310", VA = "0x182E4F310")]
		public static AreaMask GetAreaMask()
		{
			return default(AreaMask);
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x0000E778 File Offset: 0x0000C978
		[Token(Token = "0x60032B9")]
		[Address(RVA = "0x2E4F560", Offset = "0x2E4E560", VA = "0x182E4F560")]
		public static DeathMarkerGroupMask GetGroupIdMask()
		{
			return DeathMarkerGroupMask.None;
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032BA")]
		[Address(RVA = "0x2E51330", Offset = "0x2E50330", VA = "0x182E51330")]
		protected PlayerDeathCutsceneBase()
		{
		}

		// Token: 0x04002C08 RID: 11272
		[Token(Token = "0x4002C08")]
		private const string DeathSetupBreakoutPromptString = "DeathSetupBreakoutPrompt";

		// Token: 0x04002C09 RID: 11273
		[Token(Token = "0x4002C09")]
		private const string PlayerAnimatorSyncString = "PlayerAnimatorSync";

		// Token: 0x04002C0A RID: 11274
		[Token(Token = "0x4002C0A")]
		private const string PlayerLocatorPromptString = "PlayerLocator";

		// Token: 0x04002C0B RID: 11275
		[Token(Token = "0x4002C0B")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_coffinSetupPrefab")]
		[SerializeField]
		private GameObject _cutsceneStagePrefab;

		// Token: 0x04002C0C RID: 11276
		[Token(Token = "0x4002C0C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected AnimationEventReceiver _animationEventReceiver;

		// Token: 0x04002C0D RID: 11277
		[Token(Token = "0x4002C0D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _mouseRotatorLimit;

		// Token: 0x04002C0E RID: 11278
		[Token(Token = "0x4002C0E")]
		[FieldOffset(Offset = "0x38")]
		private Transform _playerLocator;

		// Token: 0x04002C0F RID: 11279
		[Token(Token = "0x4002C0F")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _routine;

		// Token: 0x04002C10 RID: 11280
		[Token(Token = "0x4002C10")]
		[FieldOffset(Offset = "0x48")]
		private readonly int _cutsceneStageHash;

		// Token: 0x04002C11 RID: 11281
		[Token(Token = "0x4002C11")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _cutsceneStageGameObject;

		// Token: 0x04002C12 RID: 11282
		[Token(Token = "0x4002C12")]
		[FieldOffset(Offset = "0x58")]
		private GameObject _breakoutPrompt;

		// Token: 0x04002C13 RID: 11283
		[Token(Token = "0x4002C13")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<DeathMarkerGroup> _registeredMarkerGroups;

		// Token: 0x04002C14 RID: 11284
		[Token(Token = "0x4002C14")]
		[FieldOffset(Offset = "0x8")]
		private static DeathCutsceneType _defaultDeathCutsceneType;

		// Token: 0x04002C15 RID: 11285
		[Token(Token = "0x4002C15")]
		[FieldOffset(Offset = "0xC")]
		private static DeathCutsceneType _deathCutsceneType;

		// Token: 0x04002C16 RID: 11286
		[Token(Token = "0x4002C16")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _playerAnimatorSyncHolder;

		// Token: 0x04002C17 RID: 11287
		[Token(Token = "0x4002C17")]
		[FieldOffset(Offset = "0x68")]
		private AnimationSync[] _playerAnimatorSyncObjects;

		// Token: 0x04002C18 RID: 11288
		[Token(Token = "0x4002C18")]
		[FieldOffset(Offset = "0x10")]
		private static PlayerDeathCutsceneMarker _overrideDeathCutsceneMarker;

		// Token: 0x04002C19 RID: 11289
		[Token(Token = "0x4002C19")]
		[FieldOffset(Offset = "0x70")]
		private bool _isCoopPlayerProxy;

		// Token: 0x04002C1A RID: 11290
		[Token(Token = "0x4002C1A")]
		[FieldOffset(Offset = "0x78")]
		private camFollowHead _cameraFollowHead;

		// Token: 0x04002C1B RID: 11291
		[Token(Token = "0x4002C1B")]
		[FieldOffset(Offset = "0x80")]
		private bool _loggingEnabled;

		// Token: 0x04002C1C RID: 11292
		[Token(Token = "0x4002C1C")]
		[FieldOffset(Offset = "0x81")]
		private bool _failed;

		// Token: 0x04002C1D RID: 11293
		[Token(Token = "0x4002C1D")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<int, PlayerDeathCutsceneMarker> _markerHashDictionary;
	}
}
