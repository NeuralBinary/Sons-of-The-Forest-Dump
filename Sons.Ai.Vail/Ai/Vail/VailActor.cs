using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ai.AiUtilities;
using Endnight.Animation;
using Endnight.Types;
using FMODUnity;
using Il2CppDummyDll;
using Pathfinding;
using Sons.Ai.Vail.Inventory;
using Sons.Ai.Vail.Memory;
using Sons.Ai.Vail.StimuliQueries;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Ai.Vail.Traits;
using Sons.Animation.Mae;
using Sons.Areas;
using Sons.Gameplay;
using Sons.Items.Core;
using Sons.Physics;
using Sons.Ragdoll;
using Sons.StatSystem;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[AddComponentMenu("Sons/Ai/Vail Actor")]
	public class VailActor : MonoBehaviour, IVailGridObject, IAnimatorMoveProxyReceiver, IMaeAnimator, ISpawnable
	{
		// Token: 0x060000EE RID: 238 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2A9B220", Offset = "0x2A99820", VA = "0x182A9B220")]
		private IEnumerable AnimStateParameters()
		{
			return null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2A9B270", Offset = "0x2A99870", VA = "0x182A9B270")]
		private IEnumerable AnimLayerParameters()
		{
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2A9B2C0", Offset = "0x2A998C0", VA = "0x182A9B2C0")]
		private void InitializeAnimatorParams()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2A9B9F0", Offset = "0x2A99FF0", VA = "0x182A9B9F0")]
		private void InitializeAnimatorLayerIndices()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2A9BC90", Offset = "0x2A9A290", VA = "0x182A9BC90")]
		private void InitializeAnimEvents()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2A9BEF0", Offset = "0x2A9A4F0", VA = "0x182A9BEF0")]
		private float GetBossIntroStartTime()
		{
			return 0f;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2A9BF10", Offset = "0x2A9A510", VA = "0x182A9BF10")]
		private void InitAnimatorSettingForState(State state)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2A9C430", Offset = "0x2A9AA30", VA = "0x182A9C430")]
		private void PlayAnimationState(AnimationParameter state, int layer = 0, float startTime = 0f)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2A9C5B0", Offset = "0x2A9ABB0", VA = "0x182A9C5B0")]
		public bool ShouldSnapToGround(State state)
		{
			return default(bool);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2A9C880", Offset = "0x2A9AE80", VA = "0x182A9C880")]
		private void UpdateAnimatorStateParams()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2A9CF50", Offset = "0x2A9B550", VA = "0x182A9CF50")]
		public void HoldHelicopter(bool active)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2A9D280", Offset = "0x2A9B880", VA = "0x182A9D280")]
		private void DropHelicopter(Transform spawnTr)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2A9D730", Offset = "0x2A9BD30", VA = "0x182A9D730")]
		public bool IsAnimOverrideLayerActive()
		{
			return default(bool);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2A9D8F0", Offset = "0x2A9BEF0", VA = "0x182A9D8F0")]
		private bool IsAnimOverrideLayerActive(int layer)
		{
			return default(bool);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2A9DA70", Offset = "0x2A9C070", VA = "0x182A9DA70")]
		public static bool IsAnimTagActive(Animator animator, List<int> tagHashes)
		{
			return default(bool);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2A9DCD0", Offset = "0x2A9C2D0", VA = "0x182A9DCD0")]
		private static bool IsAnimTagActive(Animator animator, int tagHash, bool nextTransition = false)
		{
			return default(bool);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2A9DE10", Offset = "0x2A9C410", VA = "0x182A9DE10")]
		public static bool IsAnimTagActive(Animator animator, List<AnimationParameter> tagHashes)
		{
			return default(bool);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2A9E0B0", Offset = "0x2A9C6B0", VA = "0x182A9E0B0")]
		private static bool IsAnimStateActive(Animator animator, int stateHashId)
		{
			return default(bool);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2A9E1B0", Offset = "0x2A9C7B0", VA = "0x182A9E1B0")]
		internal bool HasTag(VailAnimStateTag stateTag)
		{
			return default(bool);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2A9E1F0", Offset = "0x2A9C7F0", VA = "0x182A9E1F0")]
		internal void StartTag(VailAnimStateTag stateTag)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2A9E250", Offset = "0x2A9C850", VA = "0x182A9E250")]
		internal void EndTag(VailAnimStateTag stateTag)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2A9E2C0", Offset = "0x2A9C8C0", VA = "0x182A9E2C0")]
		private void ResetAnimStateTags()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2A9E340", Offset = "0x2A9C940", VA = "0x182A9E340")]
		private void OnTagStarted(VailAnimStateTag stateTag)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2A9ECE0", Offset = "0x2A9D2E0", VA = "0x182A9ECE0")]
		private void OnTagFinished(VailAnimStateTag stateTag)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2A9F240", Offset = "0x2A9D840", VA = "0x182A9F240")]
		internal void SetAnimBaseRotation(float baseRotation)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2A9F400", Offset = "0x2A9DA00", VA = "0x182A9F400")]
		private bool IsProne()
		{
			return default(bool);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2A9F450", Offset = "0x2A9DA50", VA = "0x182A9F450")]
		private void UpdateProneStomach()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2A9F4F0", Offset = "0x2A9DAF0", VA = "0x182A9F4F0")]
		private void UpdateProneBack()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2A9F590", Offset = "0x2A9DB90", VA = "0x182A9F590")]
		private void UpdateYellFace()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2A9F630", Offset = "0x2A9DC30", VA = "0x182A9F630")]
		public void EnablePushCollision(bool value)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2A9F780", Offset = "0x2A9DD80", VA = "0x182A9F780")]
		private bool GetAnimTagDebugString(out string debugStr, out int numLines)
		{
			return default(bool);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2A9F920", Offset = "0x2A9DF20", VA = "0x182A9F920")]
		private void TickAudio()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2A9FA80", Offset = "0x2A9E080", VA = "0x182A9FA80")]
		private void SetCapsuleHeight(float newHeight)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2A9FD10", Offset = "0x2A9E310", VA = "0x182A9FD10")]
		private void SetCrouchedCollision(bool crouched)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2A9FE70", Offset = "0x2A9E470", VA = "0x182A9FE70")]
		private void SetProneCollision(bool prone)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2A9FF70", Offset = "0x2A9E570", VA = "0x182A9FF70")]
		private bool CheckAutoCrouch()
		{
			return default(bool);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2AA0000", Offset = "0x2A9E600", VA = "0x182AA0000")]
		private bool SphereForwardCastBlocked(float height, float castDist = 1f)
		{
			return default(bool);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2AA0290", Offset = "0x2A9E890", VA = "0x182AA0290")]
		private bool BoxForwardCastBlocked(float minHeight, float maxHeight, float castDist = 1f)
		{
			return default(bool);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2AA0690", Offset = "0x2A9EC90", VA = "0x182AA0690")]
		private bool CheckCanUnCrouch()
		{
			return default(bool);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2AA0940", Offset = "0x2A9EF40", VA = "0x182AA0940")]
		private bool CheckShouldCrouch()
		{
			return default(bool);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2AA09A0", Offset = "0x2A9EFA0", VA = "0x182AA09A0")]
		private void ShowGrouchGizmos()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2AA1020", Offset = "0x2A9F620", VA = "0x182AA1020")]
		private void OnDrawGizmoAutoCrouch()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2AA1040", Offset = "0x2A9F640", VA = "0x182AA1040")]
		private void InitializeAutoJump()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2AA11C0", Offset = "0x2A9F7C0", VA = "0x182AA11C0")]
		private bool CheckAutoJump()
		{
			return default(bool);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2AA2740", Offset = "0x2AA0D40", VA = "0x182AA2740")]
		private bool CheckJumpDown(Vector3 position, Vector3 forwardDir)
		{
			return default(bool);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2AA2CE0", Offset = "0x2AA12E0", VA = "0x182AA2CE0")]
		private void OnDrawGizmoAutoJump()
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x17000011")]
		public VailActorTypeId TypeId
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2AA2F20", Offset = "0x2AA1520", VA = "0x182AA2F20")]
			get
			{
				return VailActorTypeId.None;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x17000012")]
		public VailActorClassId ClassId
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x2AA2F30", Offset = "0x2AA1530", VA = "0x182AA2F30")]
			get
			{
				return VailActorClassId.None;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x17000013")]
		public int FamilyId
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2AA2F40", Offset = "0x2AA1540", VA = "0x182AA2F40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000227A File Offset: 0x0000047A
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		public string TypeIdString
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2AA2F60", Offset = "0x2AA1560", VA = "0x182AA2F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2AA2F70", Offset = "0x2AA1570", VA = "0x182AA2F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2866A50", Offset = "0x2865050", VA = "0x182866A50")]
		public WorldSimController GetWorldSimController()
		{
			return null;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000015")]
		public MonoBehaviourStimuli ActorStimuli
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2AA2FD0", Offset = "0x2AA15D0", VA = "0x182AA2FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x17000016")]
		public int TickOffset
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x2AA2FE0", Offset = "0x2AA15E0", VA = "0x182AA2FE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x17000017")]
		public bool AllowDeactivate
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2AA2FF0", Offset = "0x2AA15F0", VA = "0x182AA2FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x17000018")]
		public float RelevantDistance
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2AA3000", Offset = "0x2AA1600", VA = "0x182AA3000")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x17000019")]
		public bool PersistentStats
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2AA3010", Offset = "0x2AA1610", VA = "0x182AA3010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x1700001A")]
		public VailGiftManager GiftManager
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2651EB0", Offset = "0x26504B0", VA = "0x182651EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x1700001B")]
		public bool HasEventMemory
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x2AA3020", Offset = "0x2AA1620", VA = "0x182AA3020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2AA30E0", Offset = "0x2AA16E0", VA = "0x182AA30E0")]
		public float GetArmorLevel()
		{
			return 0f;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2AA30F0", Offset = "0x2AA16F0", VA = "0x182AA30F0")]
		public Transform GetDragAllyTransform()
		{
			return null;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x1700001C")]
		public float MoveSpeedLite
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2AA3100", Offset = "0x2AA1700", VA = "0x182AA3100")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		private event Action<VailActor, Group, IStimuli, Thought, Priority> PreActionCallbacks
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x2AA3110", Offset = "0x2AA1710", VA = "0x182AA3110")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x2AA3280", Offset = "0x2AA1880", VA = "0x182AA3280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		private event Action<InterruptReason> InterruptActionCallbacks
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x2AA33F0", Offset = "0x2AA19F0", VA = "0x182AA33F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x2AA3560", Offset = "0x2AA1B60", VA = "0x182AA3560")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2AA36D0", Offset = "0x2AA1CD0", VA = "0x182AA36D0")]
		private Color GetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2AA3770", Offset = "0x2AA1D70", VA = "0x182AA3770")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x1700001D")]
		public VailAnimEvents AnimEvents
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2AA37B0", Offset = "0x2AA1DB0", VA = "0x182AA37B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x1700001E")]
		public Transform LeftHand
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2AA37C0", Offset = "0x2AA1DC0", VA = "0x182AA37C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2AA37D0", Offset = "0x2AA1DD0", VA = "0x182AA37D0")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2AA37E0", Offset = "0x2AA1DE0", VA = "0x182AA37E0")]
		public float GetVeryCloseDistance()
		{
			return 0f;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2AA3830", Offset = "0x2AA1E30", VA = "0x182AA3830")]
		public float GetNearDistance()
		{
			return 0f;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2AA3880", Offset = "0x2AA1E80", VA = "0x182AA3880")]
		public float GetFarDistance()
		{
			return 0f;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x1700001F")]
		public RagdollManager RagdollManager
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2AA38D0", Offset = "0x2AA1ED0", VA = "0x182AA38D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00002928 File Offset: 0x00000B28
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public bool IsAttachedPrey
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2AA38E0", Offset = "0x2AA1EE0", VA = "0x182AA38E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2AA38F0", Offset = "0x2AA1EF0", VA = "0x182AA38F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x17000021")]
		public int DismemberMask
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2AA3900", Offset = "0x2AA1F00", VA = "0x182AA3900")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x17000022")]
		public int BloodMask
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2AA39F0", Offset = "0x2AA1FF0", VA = "0x182AA39F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2AA3AE0", Offset = "0x2AA20E0", VA = "0x182AA3AE0")]
		private void Awake()
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2AA4110", Offset = "0x2AA2710", VA = "0x182AA4110")]
		private void Start()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2AA4120", Offset = "0x2AA2720", VA = "0x182AA4120")]
		private void OnEnable()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2AA41C0", Offset = "0x2AA27C0", VA = "0x182AA41C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2AA42D0", Offset = "0x2AA28D0", VA = "0x182AA42D0")]
		public WorldSimActor GetWorldSimActor()
		{
			return null;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x17000023")]
		public int UniqueId
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2AA42E0", Offset = "0x2AA28E0", VA = "0x182AA42E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2AA42F0", Offset = "0x2AA28F0", VA = "0x182AA42F0")]
		public void SetWorldSimActor(WorldSimActor worldActor)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2AA4AE0", Offset = "0x2AA30E0", VA = "0x182AA4AE0")]
		private bool TrySetOutfit(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2AA4CC0", Offset = "0x2AA32C0", VA = "0x182AA4CC0")]
		public void SetOutfit(string outfitName)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2AA4DD0", Offset = "0x2AA33D0", VA = "0x182AA4DD0")]
		public void SetOutfitIndex(int outfitIndex)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2AA4F50", Offset = "0x2AA3550", VA = "0x182AA4F50")]
		private void OnOutfitChanged()
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2AA5030", Offset = "0x2AA3630", VA = "0x182AA5030")]
		public int GetCurrentOutfitItemId()
		{
			return 0;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2AA51C0", Offset = "0x2AA37C0", VA = "0x182AA51C0")]
		public int GetOutfitIndex()
		{
			return 0;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2AA52B0", Offset = "0x2AA38B0", VA = "0x182AA52B0")]
		public int GetCurrentVariationId()
		{
			return 0;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2AA5400", Offset = "0x2AA3A00", VA = "0x182AA5400")]
		public string GetOutfitName()
		{
			return null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2AA55B0", Offset = "0x2AA3BB0", VA = "0x182AA55B0")]
		public void ApplySeedToChildren(int seed, int subSet)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014D")]
		private void VerifyOrAddComponent<T>(ref T result) where T : Component
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2AA55C0", Offset = "0x2AA3BC0", VA = "0x182AA55C0")]
		private void InitializeDamageController()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2AA5790", Offset = "0x2AA3D90", VA = "0x182AA5790")]
		public void SetArmorLevel(float armorLevel, int actorSeed)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2AA5870", Offset = "0x2AA3E70", VA = "0x182AA5870")]
		public void SetSkinned(bool isSkinned, bool networkReplicate = false)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2AA5CF0", Offset = "0x2AA42F0", VA = "0x182AA5CF0")]
		public void SetBurnBodyState()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2AA5EE0", Offset = "0x2AA44E0", VA = "0x182AA5EE0")]
		public WorldSimActor VerifyRegisteredWithWorldSim()
		{
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2AA6100", Offset = "0x2AA4700", VA = "0x182AA6100")]
		private void OnActorEnabled()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2AA6C60", Offset = "0x2AA5260", VA = "0x182AA6C60")]
		public void Initialize()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2AA7260", Offset = "0x2AA5860", VA = "0x182AA7260")]
		private void OnValidate()
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2AA7330", Offset = "0x2AA5930", VA = "0x182AA7330")]
		private void AutoGatherComponents()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2AA8360", Offset = "0x2AA6960", VA = "0x182AA8360")]
		public void Deactivate()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2AA8820", Offset = "0x2AA6E20", VA = "0x182AA8820")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2AA8AA0", Offset = "0x2AA70A0", VA = "0x182AA8AA0")]
		public void AttachIfNeeded()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2AA8B80", Offset = "0x2AA7180", VA = "0x182AA8B80")]
		private void PusherActive(bool value)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2AA8E50", Offset = "0x2AA7450", VA = "0x182AA8E50")]
		private void UpdateOverrideControllers()
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2AA9230", Offset = "0x2AA7830", VA = "0x182AA9230")]
		public bool AllowVeryHighPriorityInterrupts()
		{
			return default(bool);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2AA92F0", Offset = "0x2AA78F0", VA = "0x182AA92F0")]
		public void Tick(bool fullTick, float deltaTime, float distanceToCamera)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2AAA190", Offset = "0x2AA8790", VA = "0x182AAA190")]
		public void TickNetworkActorServer()
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2AAA230", Offset = "0x2AA8830", VA = "0x182AAA230")]
		public void TickNetworkActorClient()
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2AAA2D0", Offset = "0x2AA88D0", VA = "0x182AAA2D0")]
		public void NetworkActivateClient(bool active)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2AAA5A0", Offset = "0x2AA8BA0", VA = "0x182AAA5A0")]
		public void HidePausedActor()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2AAA680", Offset = "0x2AA8C80", VA = "0x182AAA680")]
		public void TickClient(bool fullTick, Vector3 viewerPos)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2AAAC80", Offset = "0x2AA9280", VA = "0x182AAAC80")]
		public void TickMovementClient(float deltaTime)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2AAACB0", Offset = "0x2AA92B0", VA = "0x182AAACB0")]
		private void UpdateNearbyInfluence(float deltaTime)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		private void UpdateInfluence<T>(StimuliInfluenceValues influenceValues, Type influenceType, float scale, float deltaTime) where T : Stat
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2AAB210", Offset = "0x2AA9810", VA = "0x182AAB210")]
		private bool GetNextAction(Priority interruptPriority)
		{
			return default(bool);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2AAB410", Offset = "0x2AA9A10", VA = "0x182AAB410")]
		private bool RunController(Priority currentPriority, Priority interruptPriority)
		{
			return default(bool);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2AAB510", Offset = "0x2AA9B10", VA = "0x182AAB510")]
		private bool UseIsolation(out bool newThought)
		{
			return default(bool);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2AAB5E0", Offset = "0x2AA9BE0", VA = "0x182AAB5E0")]
		public void SetInitialState(State initialState)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2AABB10", Offset = "0x2AAA110", VA = "0x182AABB10")]
		public void SetCurrentState(State newState, bool initialState = false)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2AABD00", Offset = "0x2AAA300", VA = "0x182AABD00")]
		private void OnExitState(State oldState, State newState)
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2AAC150", Offset = "0x2AAA750", VA = "0x182AAC150")]
		private void OnEnterState(State newState)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2AAC550", Offset = "0x2AAAB50", VA = "0x182AAC550")]
		public void ResetCurrentStateTime()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2AAC5B0", Offset = "0x2AAABB0", VA = "0x182AAC5B0")]
		private void UpdateCombatAwareTime()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2AAC630", Offset = "0x2AAAC30", VA = "0x182AAC630")]
		public float GetCombatTime()
		{
			return 0f;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2AAC6A0", Offset = "0x2AAACA0", VA = "0x182AAC6A0")]
		public float GetCurrentStateTime()
		{
			return 0f;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2AAC700", Offset = "0x2AAAD00", VA = "0x182AAC700")]
		public float GetAngerMultiplier()
		{
			return 0f;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2AAC770", Offset = "0x2AAAD70", VA = "0x182AAC770")]
		public float GetFearMultiplier()
		{
			return 0f;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2AAC7F0", Offset = "0x2AAADF0", VA = "0x182AAC7F0")]
		private int GetNearbyFriendCount()
		{
			return 0;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2AAC8F0", Offset = "0x2AAAEF0", VA = "0x182AAC8F0")]
		private float GetGroupFearMultiplier()
		{
			return 0f;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2AACA80", Offset = "0x2AAB080", VA = "0x182AACA80")]
		private void ValidateCurrentState()
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2AACD20", Offset = "0x2AAB320", VA = "0x182AACD20")]
		public int GetExpression()
		{
			return 0;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2AACE90", Offset = "0x2AAB490", VA = "0x182AACE90")]
		public void SetExpression(int index)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2AAD010", Offset = "0x2AAB610", VA = "0x182AAD010")]
		private void UpdateLookAtAndAttention(float distanceToCamera)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2AAD4A0", Offset = "0x2AABAA0", VA = "0x182AAD4A0")]
		public Vector3 GetEyePosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2AAD5C0", Offset = "0x2AABBC0", VA = "0x182AAD5C0")]
		public Vector3 GetMidpoint()
		{
			return default(Vector3);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2AAD6A0", Offset = "0x2AABCA0", VA = "0x182AAD6A0")]
		public void SetLookAtEnabled(bool value)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2AAD7A0", Offset = "0x2AABDA0", VA = "0x182AAD7A0")]
		public void SetActiveStimuli(IStimuli stimuli)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2AADC20", Offset = "0x2AAC220", VA = "0x182AADC20")]
		public void SetScaleMult(float scale)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2AADE10", Offset = "0x2AAC410", VA = "0x182AADE10")]
		public float GetScaleMult()
		{
			return 0f;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2AADE20", Offset = "0x2AAC420", VA = "0x182AADE20")]
		public State GetState()
		{
			return default(State);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2AADE40", Offset = "0x2AAC440", VA = "0x182AADE40")]
		public bool HasStimuli(IStimuliQuery query, out IStimuli stimuli, float maxDistance = 0f)
		{
			return default(bool);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2AAE040", Offset = "0x2AAC640", VA = "0x182AAE040")]
		public void RegisterPreActionCallback(Action<VailActor, Group, IStimuli, Thought, Priority> action)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2AAE1C0", Offset = "0x2AAC7C0", VA = "0x182AAE1C0")]
		public void UnregisterPreActionCallback(Action<VailActor, Group, IStimuli, Thought, Priority> action)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2AAE1D0", Offset = "0x2AAC7D0", VA = "0x182AAE1D0")]
		public void PerformAction(Group group, IStimuli stimuli, Thought thought, bool isFollowingSequence)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2AAEB40", Offset = "0x2AAD140", VA = "0x182AAEB40")]
		public bool TryRunGroup(Group runGroup)
		{
			return default(bool);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2AAEBC0", Offset = "0x2AAD1C0", VA = "0x182AAEBC0")]
		private void SetActiveAction(MaeSequence sequenceAsset)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2AAEEE0", Offset = "0x2AAD4E0", VA = "0x182AAEEE0")]
		private void ClearActiveAction()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2AAF260", Offset = "0x2AAD860", VA = "0x182AAF260")]
		private static bool IsInterruptPathRelated(InterruptReason reason)
		{
			return default(bool);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2AAF280", Offset = "0x2AAD880", VA = "0x182AAF280")]
		public void InterruptCurrentAction(InterruptReason reason)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2AAF6D0", Offset = "0x2AADCD0", VA = "0x182AAF6D0")]
		private void EndCurrentAction()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2AAF810", Offset = "0x2AADE10", VA = "0x182AAF810")]
		private bool UpdateActiveAction()
		{
			return default(bool);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2AAFE00", Offset = "0x2AAE400", VA = "0x182AAFE00")]
		private void SwitchStateFromThought(Thought thought)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2AAFFF0", Offset = "0x2AAE5F0", VA = "0x182AAFFF0")]
		public void InitializeStatsManager(WorldSimActor worldActor)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2AB0100", Offset = "0x2AAE700", VA = "0x182AB0100")]
		public void SetMaxHealthStat(StatsManager statsManager, int variationId)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2AB0370", Offset = "0x2AAE970", VA = "0x182AB0370")]
		public float GetDamageMultiplier()
		{
			return 0f;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2AB0380", Offset = "0x2AAE980", VA = "0x182AB0380")]
		public Stat GetStat(string statId)
		{
			return null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000190")]
		public Stat GetStat<T>() where T : Stat
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000191")]
		public Stat GetStat<T>(IStimuli stimuli) where T : Stat
		{
			return null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2AB04B0", Offset = "0x2AAEAB0", VA = "0x182AB04B0")]
		private Stat GetStat(Type targetType)
		{
			return null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000193")]
		private Trait GetTrait<T>()
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2AB04E0", Offset = "0x2AAEAE0", VA = "0x182AB04E0")]
		private Trait GetTrait(Type targetType)
		{
			return null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2AB05E0", Offset = "0x2AAEBE0", VA = "0x182AB05E0")]
		public Stat GetStatOrTrait(Type targetType, IStimuli stimuli)
		{
			return null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2AB0810", Offset = "0x2AAEE10", VA = "0x182AB0810")]
		public Stat GetMemoryInfluence(Type influenceType, MonoBehaviourStimuli stimuli)
		{
			return null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2AB0920", Offset = "0x2AAEF20", VA = "0x182AB0920")]
		public float GetHealth()
		{
			return 0f;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2AB09A0", Offset = "0x2AAEFA0", VA = "0x182AB09A0", Slot = "6")]
		public Animator GetAnimator()
		{
			return null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2AB09B0", Offset = "0x2AAEFB0", VA = "0x182AB09B0")]
		public void IgnoreCollision(Collider other, bool ignore = true)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2AB0BF0", Offset = "0x2AAF1F0", VA = "0x182AB0BF0", Slot = "26")]
		public void SetAttention(bool overrideActive, int frequency, int expression)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2AB0D00", Offset = "0x2AAF300", VA = "0x182AB0D00", Slot = "27")]
		public void SetRagdoll(bool setValue)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2AB0D10", Offset = "0x2AAF310", VA = "0x182AB0D10")]
		public void SetRagdoll(bool setValue, RagdollManager.RagdollState state)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2AB1100", Offset = "0x2AAF700", VA = "0x182AB1100")]
		public bool IsOnSpringTrapCooldown()
		{
			return default(bool);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2AB1160", Offset = "0x2AAF760", VA = "0x182AB1160")]
		public void StartSpringTrapCooldown()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2AB11C0", Offset = "0x2AAF7C0", VA = "0x182AB11C0")]
		public void SetRagdollSpringTrap()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2AB1400", Offset = "0x2AAFA00", VA = "0x182AB1400")]
		private void UpdateCooldowns()
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2AB1920", Offset = "0x2AAFF20", VA = "0x182AB1920")]
		private void StartCooldown(Group group, bool actionComplete)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2AB1B30", Offset = "0x2AB0130", VA = "0x182AB1B30")]
		public bool GroupInCooldown(Group group)
		{
			return default(bool);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2AB1DD0", Offset = "0x2AB03D0", VA = "0x182AB1DD0")]
		public void StartRandomCooldown(Condition condition, float cooldown)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2AB1F50", Offset = "0x2AB0550", VA = "0x182AB1F50")]
		public bool RandomInCooldown(Condition condition)
		{
			return default(bool);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2AB2050", Offset = "0x2AB0650", VA = "0x182AB2050")]
		public void ApplyStatsAdjustments(List<StatAdjustment> adjustments, float multiplier = 1f)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2AB2080", Offset = "0x2AB0680", VA = "0x182AB2080")]
		public void ApplyInfluenceAdjustments(List<StatAdjustment> adjustments, MonoBehaviourStimuli source, float multiplier = 1f)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2AB20B0", Offset = "0x2AB06B0", VA = "0x182AB20B0")]
		public void ApplyAdjustmentLists(IReadOnlyList<StatAdjustmentsByClass> adjustmentLists, MonoBehaviourStimuli stimuliSource, float factor)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2AB23B0", Offset = "0x2AB09B0", VA = "0x182AB23B0")]
		public static bool ActorsShouldProcess(EventStimuli ev)
		{
			return default(bool);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2AB2500", Offset = "0x2AB0B00", VA = "0x182AB2500")]
		public void ProcessEvent(EventStimuli ev, float factor)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2AB2780", Offset = "0x2AB0D80", VA = "0x182AB2780")]
		public void ProcessAura(AuraInfluence aura, float factor)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2AB2830", Offset = "0x2AB0E30", VA = "0x182AB2830")]
		public void DebugAdjustMemory(string statType, float value, MonoBehaviourStimuli forStimuli)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2AB2D50", Offset = "0x2AB1350", VA = "0x182AB2D50")]
		private void TriggerMemoryEvent(MemoryEvent memoryEvent, MonoBehaviourStimuli targetStimuli)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2AB2FC0", Offset = "0x2AB15C0", VA = "0x182AB2FC0")]
		private float GetActiveThoughtTime()
		{
			return 0f;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2AB3020", Offset = "0x2AB1620", VA = "0x182AB3020")]
		public Group GetActiveGroup()
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2AB3040", Offset = "0x2AB1640", VA = "0x182AB3040")]
		public void AddOverride(VailControllerOverride source)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2AB3240", Offset = "0x2AB1840", VA = "0x182AB3240")]
		public void RemoveOverride(VailControllerOverride source)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2AB32A0", Offset = "0x2AB18A0", VA = "0x182AB32A0")]
		public bool HasOverrideController()
		{
			return default(bool);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2AB32F0", Offset = "0x2AB18F0", VA = "0x182AB32F0")]
		public float OverrideActiveTime()
		{
			return 0f;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x67D9B0", Offset = "0x67BFB0", VA = "0x18067D9B0")]
		public List<VailControllerOverride> OverrideControllers()
		{
			return null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2AB3380", Offset = "0x2AB1980", VA = "0x182AB3380")]
		public void AdjustCurrentThoughtPriority(Priority newPriority)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000024")]
		private Priority CurrentThoughtPriority
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x2AB33E0", Offset = "0x2AB19E0", VA = "0x182AB33E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2AB33F0", Offset = "0x2AB19F0", VA = "0x182AB33F0")]
		public void ForceDeath()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2AB3470", Offset = "0x2AB1A70", VA = "0x182AB3470")]
		public void ReceivedMessage(MessageTarget.Message message, VailActor sender)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2AB39C0", Offset = "0x2AB1FC0", VA = "0x182AB39C0")]
		private void GenerateBushSearchEvent()
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2AB3C30", Offset = "0x2AB2230", VA = "0x182AB3C30")]
		public void GrabPrey(string namedGrabTransform, VailActor preyActor, Transform attachTransform)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2AB4120", Offset = "0x2AB2720", VA = "0x182AB4120")]
		private void UpdateAttachedPrey()
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2AB4580", Offset = "0x2AB2B80", VA = "0x182AB4580")]
		public void DropPrey()
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2AB4910", Offset = "0x2AB2F10", VA = "0x182AB4910")]
		public void TriggerFX(string fxId)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2AB4960", Offset = "0x2AB2F60", VA = "0x182AB4960")]
		public void ShowObject(string objectName, bool active)
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2AB4AD0", Offset = "0x2AB30D0", VA = "0x182AB4AD0")]
		public void HitSnapDir()
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x174E4D0", Offset = "0x174CAD0", VA = "0x18174E4D0")]
		public VailStatsManager GetStatsManager()
		{
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2AB4B40", Offset = "0x2AB3140", VA = "0x182AB4B40")]
		public ActorMemory GetActorMemory()
		{
			return null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2AB4B50", Offset = "0x2AB3150", VA = "0x182AB4B50")]
		public IRobbyCallbacks GetRobbyCallbacks()
		{
			return null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2AB4B80", Offset = "0x2AB3180", VA = "0x182AB4B80")]
		public void RegisterInterruptActionCallback(Action<InterruptReason> action)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2AA3560", Offset = "0x2AA1B60", VA = "0x182AA3560")]
		public void UnregisterInterruptActionCallback(Action<InterruptReason> action)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2AB4D00", Offset = "0x2AB3300", VA = "0x182AB4D00")]
		public static bool CanSeeFilterDelegate(VailActor actor, IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2AB4E20", Offset = "0x2AB3420", VA = "0x182AB4E20")]
		public static bool NotHiddenFilterDelegate(VailActor actor, IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2AB4FA0", Offset = "0x2AB35A0", VA = "0x182AB4FA0")]
		public Transform GetNamedObject(string namedObjectId, bool warnMissing = false)
		{
			return null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2AB52E0", Offset = "0x2AB38E0", VA = "0x182AB52E0")]
		private void UpdateOnTreeState()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2AB57D0", Offset = "0x2AB3DD0", VA = "0x182AB57D0")]
		private void DyingRecoverHealth(float deltaTime)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2AB5880", Offset = "0x2AB3E80", VA = "0x182AB5880")]
		private void UpdateOnFireState(float deltaTime)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2AB5B40", Offset = "0x2AB4140", VA = "0x182AB5B40")]
		public void Revive()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2AB5C30", Offset = "0x2AB4230", VA = "0x182AB5C30")]
		private bool DamageActor(float damage, bool preventDeath)
		{
			return default(bool);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2AB5DE0", Offset = "0x2AB43E0", VA = "0x182AB5DE0")]
		public void DrainHealth(float amount)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2AB5F40", Offset = "0x2AB4540", VA = "0x182AB5F40")]
		public float CurrentWetness()
		{
			return 0f;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2AB5F50", Offset = "0x2AB4550", VA = "0x182AB5F50")]
		public void SetCurrentWetness(float value)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2AB5F60", Offset = "0x2AB4560", VA = "0x182AB5F60")]
		public void AdjustCurrentWetness(float delta)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2AB5F90", Offset = "0x2AB4590", VA = "0x182AB5F90")]
		private void UpdateCleanliness(float deltaTime)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2AB6A00", Offset = "0x2AB5000", VA = "0x182AB6A00")]
		public void ApplyWaterCleaning(float amount)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2AB6C50", Offset = "0x2AB5250", VA = "0x182AB6C50")]
		public void ApplyBlood(string partId = "")
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2AB6D40", Offset = "0x2AB5340", VA = "0x182AB6D40")]
		public void ApplyDirt(float amount)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2AB6E30", Offset = "0x2AB5430", VA = "0x182AB6E30")]
		public void SetThoughtPersistentStimuli(bool persistent)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2AB6E40", Offset = "0x2AB5440", VA = "0x182AB6E40")]
		private void SetDead(bool dead)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2AB7140", Offset = "0x2AB5740", VA = "0x182AB7140")]
		private void OnEnterDying()
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2AB72C0", Offset = "0x2AB58C0", VA = "0x182AB72C0")]
		private void OnExitDying()
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2AB7440", Offset = "0x2AB5A40", VA = "0x182AB7440")]
		private void OnDeath()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2AB76E0", Offset = "0x2AB5CE0", VA = "0x182AB76E0")]
		public bool IsDead()
		{
			return default(bool);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2AB76F0", Offset = "0x2AB5CF0", VA = "0x182AB76F0")]
		public bool IsDying()
		{
			return default(bool);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2AB7760", Offset = "0x2AB5D60", VA = "0x182AB7760")]
		public bool IsBodyBurning()
		{
			return default(bool);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2AB7770", Offset = "0x2AB5D70", VA = "0x182AB7770")]
		public bool IsDismembered()
		{
			return default(bool);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2AB7780", Offset = "0x2AB5D80", VA = "0x182AB7780")]
		public bool CanBeRevived()
		{
			return default(bool);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2AB7820", Offset = "0x2AB5E20", VA = "0x182AB7820")]
		public bool IsSkinned()
		{
			return default(bool);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2AB7840", Offset = "0x2AB5E40", VA = "0x182AB7840")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2AB78B0", Offset = "0x2AB5EB0", VA = "0x182AB78B0")]
		public bool IsInCave()
		{
			return default(bool);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x17000025")]
		public AreaMask AreaMask
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x2AB78D0", Offset = "0x2AB5ED0", VA = "0x182AB78D0")]
			get
			{
				return AreaMask.None;
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2AB78F0", Offset = "0x2AB5EF0", VA = "0x182AB78F0")]
		private bool IsAlerted()
		{
			return default(bool);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2AB79E0", Offset = "0x2AB5FE0", VA = "0x182AB79E0")]
		public bool IsInCombatAwareState()
		{
			return default(bool);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2AB7A60", Offset = "0x2AB6060", VA = "0x182AB7A60")]
		public static bool IsCombatAwareState(State state)
		{
			return default(bool);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2AB7BA0", Offset = "0x2AB61A0", VA = "0x182AB7BA0")]
		public bool IsInLowState()
		{
			return default(bool);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2AB7C50", Offset = "0x2AB6250", VA = "0x182AB7C50")]
		public bool IsImmuneToPlayerTraps(bool ignoreSmallAnimals)
		{
			return default(bool);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2AB7C90", Offset = "0x2AB6290", VA = "0x182AB7C90")]
		public bool IsVailControllerType(VailController checkController)
		{
			return default(bool);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2AB7DC0", Offset = "0x2AB63C0", VA = "0x182AB7DC0")]
		public void IgniteBody(bool onlyIfDead)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2AB7EE0", Offset = "0x2AB64E0", VA = "0x182AB7EE0")]
		public void SetRobbyInjured(bool value)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2AB7F80", Offset = "0x2AB6580", VA = "0x182AB7F80")]
		public bool IsRobbyInjured()
		{
			return default(bool);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2AB7F90", Offset = "0x2AB6590", VA = "0x182AB7F90")]
		public void SetDamageEnabled(bool value)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2AB7FC0", Offset = "0x2AB65C0", VA = "0x182AB7FC0")]
		public void DismemberRandomPart()
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2AB8160", Offset = "0x2AB6760", VA = "0x182AB8160")]
		public bool CheckPlayerSentimentLevel(int minSentimentLevel)
		{
			return default(bool);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2AB82F0", Offset = "0x2AB68F0", VA = "0x182AB82F0")]
		public void OnEnterCombat()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2AB86E0", Offset = "0x2AB6CE0", VA = "0x182AB86E0")]
		public void OnCapturedStateChanged(bool captured)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2AB87B0", Offset = "0x2AB6DB0", VA = "0x182AB87B0", Slot = "32")]
		private void SpawnInitialize(GameObject root)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2AB87C0", Offset = "0x2AB6DC0", VA = "0x182AB87C0")]
		public float SampleEventMemory(MemoryEvent memoryEvent)
		{
			return 0f;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2AB88F0", Offset = "0x2AB6EF0", VA = "0x182AB88F0")]
		public float SampleShouldFight(VailActor actor)
		{
			return 0f;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2AB8B10", Offset = "0x2AB7110", VA = "0x182AB8B10")]
		private bool GetEventMemoryDebugString(out string debugStr, out int numLines)
		{
			return default(bool);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2AB8CD0", Offset = "0x2AB72D0", VA = "0x182AB8CD0")]
		public static string OpenColor(Color color)
		{
			return null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2AB8D70", Offset = "0x2AB7370", VA = "0x182AB8D70")]
		public static string OpenColor(string colorString)
		{
			return null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2AB8DC0", Offset = "0x2AB73C0", VA = "0x182AB8DC0")]
		public static string GetAnimStateName(int shortNameHash)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2AB8E10", Offset = "0x2AB7410", VA = "0x182AB8E10")]
		public string GetVailReadout(int typeIdx, int typeCount)
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2AB98D0", Offset = "0x2AB7ED0", VA = "0x182AB98D0")]
		private string GetAnimatorStateStringLayer(int layerIndex, bool useClipName = false)
		{
			return null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2AB9B90", Offset = "0x2AB8190", VA = "0x182AB9B90")]
		public string GetAnimatorStateString(out string tagString, out float normalizedTime, bool useClipName)
		{
			return null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2AB9F10", Offset = "0x2AB8510", VA = "0x182AB9F10")]
		public string GetAnimationParameterReadout()
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2ABA1D0", Offset = "0x2AB87D0", VA = "0x182ABA1D0")]
		private string GetCoolDownReadout()
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2ABA6F0", Offset = "0x2AB8CF0", VA = "0x182ABA6F0")]
		private string GetMaeMessage()
		{
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2ABA820", Offset = "0x2AB8E20", VA = "0x182ABA820")]
		public string GetThoughtMessage(bool setTargetName = true)
		{
			return null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2ABA910", Offset = "0x2AB8F10", VA = "0x182ABA910")]
		public void ShowDebugOverlay(Vector3 screenPos, VailOverlayType overlayType, IStimuli player)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2ABBDF0", Offset = "0x2ABA3F0", VA = "0x182ABBDF0")]
		public void AddToVerboseLog(string logText)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2ABBEB0", Offset = "0x2ABA4B0", VA = "0x182ABBEB0")]
		public void CopyLogToClipboard()
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2ABC250", Offset = "0x2ABA850", VA = "0x182ABC250")]
		public void CopyGroupDriversToClipboard()
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2ABC340", Offset = "0x2ABA940", VA = "0x182ABC340")]
		public void UpdateBlocking(bool newValue)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2ABC440", Offset = "0x2ABAA40", VA = "0x182ABC440")]
		public void MeleeWeaponEnabled(string id)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2ABC460", Offset = "0x2ABAA60", VA = "0x182ABC460")]
		public void MeleeWeaponDisabled(string id)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2ABC480", Offset = "0x2ABAA80", VA = "0x182ABC480")]
		public void SetMeleeWeaponEnabled(string id, bool value, int stateHash)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2ABC770", Offset = "0x2ABAD70", VA = "0x182ABC770")]
		private void UpdateMeleeIsActive()
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2ABC930", Offset = "0x2ABAF30", VA = "0x182ABC930")]
		private void SetAllMeleeWeaponsEnabled(bool value)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2ABCAA0", Offset = "0x2ABB0A0", VA = "0x182ABCAA0")]
		private void TickMeleeCollision()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2ABCCA0", Offset = "0x2ABB2A0", VA = "0x182ABCCA0")]
		private void WeaponShoot(GameObject weapon)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2ABD020", Offset = "0x2ABB620", VA = "0x182ABD020")]
		public void FireRangedWeapon(string weaponName)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2ABD2A0", Offset = "0x2ABB8A0", VA = "0x182ABD2A0")]
		public void ThrowObject(string objectName, bool start)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2ABD6B0", Offset = "0x2ABBCB0", VA = "0x182ABD6B0")]
		private void ClearAttackImpactParam()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2ABD6F0", Offset = "0x2ABBCF0", VA = "0x182ABD6F0")]
		public void OnAttackDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2ABD770", Offset = "0x2ABBD70", VA = "0x182ABD770")]
		public void OnAttackParried(IImpactData impactData)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2ABD9B0", Offset = "0x2ABBFB0", VA = "0x182ABD9B0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2ABDA10", Offset = "0x2ABC010", VA = "0x182ABDA10")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2ABDA30", Offset = "0x2ABC030", VA = "0x182ABDA30")]
		private void OnDrawGizmoVision()
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2ABE430", Offset = "0x2ABCA30", VA = "0x182ABE430")]
		private void OnDrawGizmoDrownDepth()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2ABE6D0", Offset = "0x2ABCCD0", VA = "0x182ABE6D0")]
		private void OnDrawGizmoStimuli()
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2ABE980", Offset = "0x2ABCF80", VA = "0x182ABE980")]
		private void OnDrawGizmoDistances()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2ABEE30", Offset = "0x2ABD430", VA = "0x182ABEE30")]
		private void DrawGizmoDistance(float nearDistance, Color color)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2ABF0D0", Offset = "0x2ABD6D0", VA = "0x182ABF0D0")]
		private void OnDrawGizmosPath()
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2ABF290", Offset = "0x2ABD890", VA = "0x182ABF290")]
		private void OnDrawGizmosMoveTarget()
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2ABF500", Offset = "0x2ABDB00", VA = "0x182ABF500")]
		private void InitializeAnimatorImpactParams()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2ABFAC0", Offset = "0x2ABE0C0", VA = "0x182ABFAC0")]
		private ImpactStimuli CreateStimuli(DamageNode damageNode, Vector3 senderDir, IImpactData impactData)
		{
			return null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2ABFD20", Offset = "0x2ABE320", VA = "0x182ABFD20")]
		private ImpactStimuli CreateStimuli(DamageNode sender, Vector3 senderDir, ImpactType impactType, ImpactProjectileType projectileType, ImpactMeleeType meleeType, ImpactExplosionType explosionType, Vector3 velocity, float weight, bool powerAttack, IReadOnlyList<StatusEffect> statusEffects)
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2AC02A0", Offset = "0x2ABE8A0", VA = "0x182AC02A0")]
		private static ImpactStimuli CreateMeleeStimuli(ImpactMeleeType meleeType, bool isBlocking)
		{
			return null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2AC0430", Offset = "0x2ABEA30", VA = "0x182AC0430")]
		private static ImpactStimuli CreateProjectileStimuli(ImpactProjectileType projectileType, bool isBlocking)
		{
			return null;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2AC0560", Offset = "0x2ABEB60", VA = "0x182AC0560")]
		private static ImpactStimuli CreateExplosionStimuli(ImpactExplosionType explosionType)
		{
			return null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2AC0620", Offset = "0x2ABEC20", VA = "0x182AC0620", Slot = "21")]
		public void ApplyImpactData(int direction, int impactType, int subImpactType, int location, float weight, bool overrideData)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2AC0780", Offset = "0x2ABED80", VA = "0x182AC0780")]
		private void ApplyImpactData(ImpactStimuli lastStimuli)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2AC08B0", Offset = "0x2ABEEB0", VA = "0x182AC08B0")]
		private int CalculateImpactDirection(Vector3 dataImpactVelocity)
		{
			return 0;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2AC0990", Offset = "0x2ABEF90", VA = "0x182AC0990")]
		private bool StatusContains(IReadOnlyList<StatusEffect> list, StatusEffectType statusEffectType)
		{
			return default(bool);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2AC0AE0", Offset = "0x2ABF0E0", VA = "0x182AC0AE0")]
		private void GetHitLocationAnimParams(int locationId, int direction, bool hitFromBehind, out int appliedBoolHash, out int appliedDirection)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2AC0CC0", Offset = "0x2ABF2C0", VA = "0x182AC0CC0")]
		private void ApplyImpactData(int direction, ImpactType impactType, int subImpactType, int location, float weight, bool powerAttack, Vector3 senderDir, IReadOnlyList<StatusEffect> statusEffects)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2AC1FE0", Offset = "0x2AC05E0", VA = "0x182AC1FE0")]
		private void OnImpactClient(IDamageCallbackSender damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2AC2E40", Offset = "0x2AC1440", VA = "0x182AC2E40")]
		public void ReceivedImpactFromClient(VailHitEvent ev)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2AC3940", Offset = "0x2AC1F40", VA = "0x182AC3940")]
		private void OnImpactServer(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2AC3F00", Offset = "0x2AC2500", VA = "0x182AC3F00")]
		private void ServerProcessImpact(ImmediateStimuli impactStimuli, DamageNode damageNode, float damage, MonoBehaviourStimuli sourceStimuli, Vector3 senderDir, ImpactType impactType, int subImpactType, Vector3 impactVelocity, float impactWeight, bool wasBlocked, bool criticalKnockdown, bool comboEnder, bool hitHeadFromBehind, bool fromPlayer)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2AC4470", Offset = "0x2AC2A70", VA = "0x182AC4470")]
		public void ReceivedDismemberImpactFromClient(DismemberHitEvent ev)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2AC4560", Offset = "0x2AC2B60", VA = "0x182AC4560")]
		private void SendAttackWasParriedToServer()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2AC4700", Offset = "0x2AC2D00", VA = "0x182AC4700")]
		public void ReceivedParriedFromClient(VailParriedEvent ev)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2AC4750", Offset = "0x2AC2D50", VA = "0x182AC4750")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2AC4D60", Offset = "0x2AC3360", VA = "0x182AC4D60")]
		private float CalculateDamage(IImpactData impactData)
		{
			return 0f;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2AC4DB0", Offset = "0x2AC33B0", VA = "0x182AC4DB0")]
		private bool IsHitFromBehind(Vector3 senderDir)
		{
			return default(bool);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2AC4E40", Offset = "0x2AC3440", VA = "0x182AC4E40")]
		private void UpdateStagger(ImpactType impactType, float weight, bool criticalKnockdown, bool comboEnder, bool fromPlayer)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2AC4F50", Offset = "0x2AC3550", VA = "0x182AC4F50")]
		private void HandleBleeding(ImpactType impactType, int subImpactType)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2AC4FC0", Offset = "0x2AC35C0", VA = "0x182AC4FC0")]
		private void UpdateDamageTakenStats(MonoBehaviourStimuli sourceStimuli, float damage)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2AC5100", Offset = "0x2AC3700", VA = "0x182AC5100")]
		private void HandleKnockBack(ImpactType impactType, int subImpactType, float damage, Vector3 velocity, Vector3 senderDir)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2AC5530", Offset = "0x2AC3B30", VA = "0x182AC5530")]
		private static int GetSubImpactType(IImpactData impactData)
		{
			return 0;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2AC5620", Offset = "0x2AC3C20", VA = "0x182AC5620")]
		private static int GetSubImpactType(ImpactType impactType, ImpactMeleeType meleeType, ImpactProjectileType projectileType, ImpactExplosionType explosionType)
		{
			return 0;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2AC5650", Offset = "0x2AC3C50", VA = "0x182AC5650")]
		private Vector3 GetSenderDirXZ(IImpactSender sender)
		{
			return default(Vector3);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2AC58F0", Offset = "0x2AC3EF0", VA = "0x182AC58F0")]
		public void TriggerOnHitEventStimuli(MonoBehaviourStimuli source)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2AC5A90", Offset = "0x2AC4090", VA = "0x182AC5A90")]
		public void ApplyImpactStats(MonoBehaviourStimuli source, float damage, bool blocked)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2AC63E0", Offset = "0x2AC49E0", VA = "0x182AC63E0")]
		private void ResetHitParams()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2AC6780", Offset = "0x2AC4D80", VA = "0x182AC6780")]
		public void ReceivedDamage(DamageNode source, ImpactType impactType, int subImpactType, MonoBehaviourStimuli sourceStimuli, float amount, bool fromPlayer, bool hitFromBehind)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2AC7060", Offset = "0x2AC5660", VA = "0x182AC7060")]
		private void ClearDamage()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2AC7140", Offset = "0x2AC5740", VA = "0x182AC7140")]
		public bool HasReceivedDamage(out IStimuli result)
		{
			return default(bool);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2AC7380", Offset = "0x2AC5980", VA = "0x182AC7380")]
		public bool GetDamagedBy(float distance, Type stimuliType, out IStimuli result)
		{
			return default(bool);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2AC76E0", Offset = "0x2AC5CE0", VA = "0x182AC76E0")]
		private void OnBlockedAttack(DamageNode node, IImpactData impactData)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2AC79A0", Offset = "0x2AC5FA0", VA = "0x182AC79A0")]
		private void OnBreak(IBreakSender sender, IImpactData impactData)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2AC7CA0", Offset = "0x2AC62A0", VA = "0x182AC7CA0")]
		private void RepairBreaks()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2AC7F80", Offset = "0x2AC6580", VA = "0x182AC7F80")]
		public void OnDismembered(DismembermentController.DismemberPartId partId, bool instantDeath)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2AC8180", Offset = "0x2AC6780", VA = "0x182AC8180")]
		private void SetInjured()
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2AC81B0", Offset = "0x2AC67B0", VA = "0x182AC81B0")]
		private static bool StartsWith(string senderId, string search)
		{
			return default(bool);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2AC82E0", Offset = "0x2AC68E0", VA = "0x182AC82E0")]
		public void SetInventoryCallbacks(IRobbyCallbacks callbacks)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2AC8400", Offset = "0x2AC6A00", VA = "0x182AC8400")]
		public void OnReplicatedHeldItems(int typeAndCount)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2AC8430", Offset = "0x2AC6A30", VA = "0x182AC8430")]
		public int GetNeededCount(string itemName)
		{
			return 0;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2AC8530", Offset = "0x2AC6B30", VA = "0x182AC8530")]
		public void GetInventoryCountAndType(out string itemName, out int count)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2AC8680", Offset = "0x2AC6C80", VA = "0x182AC8680")]
		public bool ShouldPlaceCarriedItems()
		{
			return default(bool);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2AC86F0", Offset = "0x2AC6CF0", VA = "0x182AC86F0")]
		public bool CanPickup(VailPickup pickup)
		{
			return default(bool);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2AC8760", Offset = "0x2AC6D60", VA = "0x182AC8760")]
		public void OnInteractAnimEvent(string param)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2AC8860", Offset = "0x2AC6E60", VA = "0x182AC8860")]
		public void OnPickup()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2AC8EB0", Offset = "0x2AC74B0", VA = "0x182AC8EB0")]
		public void PickupItem(string itemType)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2AC8FC0", Offset = "0x2AC75C0", VA = "0x182AC8FC0")]
		public void ShowPickupItem(string itemType)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2AC8FF0", Offset = "0x2AC75F0", VA = "0x182AC8FF0")]
		public void HidePickupItems()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2AC9020", Offset = "0x2AC7620", VA = "0x182AC9020")]
		public void OnCarry()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2AC91A0", Offset = "0x2AC77A0", VA = "0x182AC91A0")]
		public void OnPlace()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2AC91D0", Offset = "0x2AC77D0", VA = "0x182AC91D0")]
		public void InstantCarry(string itemName)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2AC9200", Offset = "0x2AC7800", VA = "0x182AC9200")]
		public void OnDrop()
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2AC93C0", Offset = "0x2AC79C0", VA = "0x182AC93C0")]
		public void ClearCarry()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2AC93F0", Offset = "0x2AC79F0", VA = "0x182AC93F0")]
		public string GetInventoryItemType()
		{
			return null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2AC9450", Offset = "0x2AC7A50", VA = "0x182AC9450")]
		public int GetInventoryCount(string itemNameId)
		{
			return 0;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2AC9490", Offset = "0x2AC7A90", VA = "0x182AC9490")]
		public int GetInventoryCountAll()
		{
			return 0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2AC94D0", Offset = "0x2AC7AD0", VA = "0x182AC94D0")]
		public bool CanDrop(IVailDropTarget target)
		{
			return default(bool);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2AC9560", Offset = "0x2AC7B60", VA = "0x182AC9560")]
		public int GetItemCarryTypeCount()
		{
			return 0;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2AC95A0", Offset = "0x2AC7BA0", VA = "0x182AC95A0")]
		public void OnAttachItemEvent(VailAttachItemEvent evnt)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2AC95D0", Offset = "0x2AC7BD0", VA = "0x182AC95D0")]
		private void SetStashAllActiveEquipped(bool stashed)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2AC9750", Offset = "0x2AC7D50", VA = "0x182AC9750")]
		public bool IsEquipped(int itemId)
		{
			return default(bool);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2AC98B0", Offset = "0x2AC7EB0", VA = "0x182AC98B0")]
		public void ClientSetEquippedMask(int mask)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2AC9990", Offset = "0x2AC7F90", VA = "0x182AC9990")]
		public List<int> GetEquippedItems()
		{
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2AC9B60", Offset = "0x2AC8160", VA = "0x182AC9B60")]
		public int GetEquippedCount(string itemType)
		{
			return 0;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2AC9C20", Offset = "0x2AC8220", VA = "0x182AC9C20")]
		private VailActor.EquipItem GetEquipItem(int itemId)
		{
			return null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2AC9CF0", Offset = "0x2AC82F0", VA = "0x182AC9CF0")]
		private GameObject GetEquippedObject(int itemId)
		{
			return null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2AC9E50", Offset = "0x2AC8450", VA = "0x182AC9E50")]
		private void InitEquippedItems()
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2AC9FF0", Offset = "0x2AC85F0", VA = "0x182AC9FF0")]
		private GameObject GetEquippedObject(string itemType)
		{
			return null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2ACA0D0", Offset = "0x2AC86D0", VA = "0x182ACA0D0")]
		public int GetEquippedMask()
		{
			return 0;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2ACA1B0", Offset = "0x2AC87B0", VA = "0x182ACA1B0")]
		public bool GetHelicopterHeld()
		{
			return default(bool);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2ACA1C0", Offset = "0x2AC87C0", VA = "0x182ACA1C0")]
		private static GameObject InstantiateDroppedItem(GameObject prefab, Vector3 spawnPos, Quaternion spawnRot)
		{
			return null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2ACA4E0", Offset = "0x2AC8AE0", VA = "0x182ACA4E0")]
		private void DropEquippedOnDeath()
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2ACAC20", Offset = "0x2AC9220", VA = "0x182ACAC20")]
		public bool TryGiveItem(int itemId, out int outItemReturned, [Optional] MonoBehaviourStimuli fromStimuli)
		{
			return default(bool);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2ACAD50", Offset = "0x2AC9350", VA = "0x182ACAD50")]
		public bool TryRequestItemBack(int itemId, out int outItemReturned)
		{
			return default(bool);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2ACAF70", Offset = "0x2AC9570", VA = "0x182ACAF70")]
		private void TestLocalAvoidance()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2ACB8B0", Offset = "0x2AC9EB0", VA = "0x182ACB8B0")]
		private bool TryLocalAvoidance(Vector3 hitPoint, Vector3 hitNormal, out Vector3 retPoint)
		{
			return default(bool);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2ACBD90", Offset = "0x2ACA390", VA = "0x182ACBD90", Slot = "8")]
		public void MoveToTarget(MoveToParams moveToParams)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2ACBF90", Offset = "0x2ACA590", VA = "0x182ACBF90", Slot = "10")]
		public void MoveRandom(SpeedRangeSet speed, float stopDistance, Vector2 minMaxDistance, Vector2 minMaxDirection, MoveRandomDirection dir, MoveRandomBounds boundsType, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2ACC1A0", Offset = "0x2ACA7A0", VA = "0x182ACC1A0", Slot = "7")]
		public Animator GetTargetAnimator()
		{
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2ACC2E0", Offset = "0x2ACA8E0", VA = "0x182ACC2E0", Slot = "9")]
		public void MoveToCover(MoveAligned.AlignType alignType, MoveAlignedParams moveParams)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2ACC760", Offset = "0x2ACAD60", VA = "0x182ACC760")]
		private void MoveBehindCover(Vector3 coverPos, Vector3 coverFromPos, MoveAlignedParams moveParams)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2ACC9C0", Offset = "0x2ACAFC0", VA = "0x182ACC9C0", Slot = "12")]
		public void FollowTarget(SpeedRangeSet speeds, Action complete, Action interrupted)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2ACCB50", Offset = "0x2ACB150", VA = "0x182ACCB50")]
		private void SetupMoveToWorld(MoveToParams moveToParams, Vector3 worldGoal)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2ACCEE0", Offset = "0x2ACB4E0", VA = "0x182ACCEE0")]
		private void SetupMoveToTarget(MoveToParams moveToParams, Transform targetTransform, bool targetIsStimuli = true)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2ACD430", Offset = "0x2ACBA30", VA = "0x182ACD430")]
		private Transform GetTargetOnStimuli(Transform defaultTarget, out bool isReservedLocation)
		{
			return null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2ACD610", Offset = "0x2ACBC10", VA = "0x182ACD610")]
		private void TryRemoveExisting(Transform parent, GameObject eventPrefab)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2ACD7B0", Offset = "0x2ACBDB0", VA = "0x182ACD7B0")]
		private GameObject GeneratePrefab(GameObject prefab, string targetPosition, GenerateEvent.AttachType parentToTarget, bool isUnique)
		{
			return null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2ACDEE0", Offset = "0x2ACC4E0", VA = "0x182ACDEE0")]
		private void ConstrainStimuliPosition(GameObject stimuliGo, Transform targetTransform)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2ACE0F0", Offset = "0x2ACC6F0", VA = "0x182ACE0F0", Slot = "25")]
		public void GenerateEventPrefab(GameObject eventPrefab, bool proxyTargetIsLastStimuli, string targetPosition, GenerateEvent.AttachType attachType, bool isUnique)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2ACE260", Offset = "0x2ACC860", VA = "0x182ACE260", Slot = "28")]
		public void SendMessageToTarget(MessageTarget.Target target, MessageTarget.Message message)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2ACE4C0", Offset = "0x2ACCAC0", VA = "0x182ACE4C0")]
		private Vector3 GetRandomWorldGoal(Vector2 minMax, Vector2 minMaxAngle, MoveRandomDirection dir, MoveRandomBounds boundsType)
		{
			return default(Vector3);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2ACEAA0", Offset = "0x2ACD0A0", VA = "0x182ACEAA0")]
		private void SetupMoveRandom(SpeedRangeSet speeds, Vector2 minMax, Vector2 minMaxAngle, MoveRandomDirection direction, MoveRandomBounds boundsType, float stopMinDistance, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2ACECB0", Offset = "0x2ACD2B0", VA = "0x182ACECB0", Slot = "11")]
		public void MoveAlignedToTarget(MoveAlignedParams flankParams, MoveTargetType targetType)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2ACF3B0", Offset = "0x2ACD9B0", VA = "0x182ACF3B0", Slot = "13")]
		public void StartSnapToTarget(SnapToParams snapParams)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2ACFD40", Offset = "0x2ACE340", VA = "0x182ACFD40", Slot = "14")]
		public void EndSnapToTarget()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2ACFD50", Offset = "0x2ACE350", VA = "0x182ACFD50")]
		public void SnapJumpArc(Vector3 position, float factor)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2ACFEC0", Offset = "0x2ACE4C0", VA = "0x182ACFEC0")]
		public void SnapLinear(Vector3 position, float factor)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2ACFF90", Offset = "0x2ACE590", VA = "0x182ACFF90", Slot = "15")]
		public void SnapToTarget(float factor)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2AD0640", Offset = "0x2ACEC40", VA = "0x182AD0640", Slot = "16")]
		public void HoldAtTarget()
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2AD0650", Offset = "0x2ACEC50", VA = "0x182AD0650", Slot = "17")]
		public void AlignTo(AlignToParams alignToParams)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2AD08E0", Offset = "0x2ACEEE0", VA = "0x182AD08E0", Slot = "18")]
		public void BeginInteraction(Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2AD0990", Offset = "0x2ACEF90", VA = "0x182AD0990", Slot = "19")]
		public void Interact(float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2AD0A60", Offset = "0x2ACF060", VA = "0x182AD0A60", Slot = "20")]
		public void EndInteraction(Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2AD0AF0", Offset = "0x2ACF0F0", VA = "0x182AD0AF0", Slot = "22")]
		public void SetShouldChangeState()
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2AD0B00", Offset = "0x2ACF100", VA = "0x182AD0B00")]
		private Vector3 GetRandomLandPoint(Vector2 distanceRange)
		{
			return default(Vector3);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2AD0E10", Offset = "0x2ACF410", VA = "0x182AD0E10", Slot = "23")]
		public void FollowFlightPath(FlightPath.PathType pathType, FlightPathParams flightParams)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2AD1DB0", Offset = "0x2AD03B0", VA = "0x182AD1DB0", Slot = "24")]
		public void FollowSurfacePath(SurfacePathParams pathParams)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2AD1F90", Offset = "0x2AD0590", VA = "0x182AD1F90", Slot = "31")]
		public bool CanEndBlock()
		{
			return default(bool);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2AD2180", Offset = "0x2AD0780", VA = "0x182AD2180")]
		private bool PreControllerMove(Vector3 position, ref Vector3 moveDelta)
		{
			return default(bool);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2AD2460", Offset = "0x2AD0A60", VA = "0x182AD2460", Slot = "4")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2AD2490", Offset = "0x2AD0A90", VA = "0x182AD2490")]
		public Vector3 VisualPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2AD2650", Offset = "0x2AD0C50", VA = "0x182AD2650")]
		public Quaternion Rotation()
		{
			return default(Quaternion);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2AD2720", Offset = "0x2AD0D20", VA = "0x182AD2720")]
		public float DepthInWater()
		{
			return 0f;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2AD2740", Offset = "0x2AD0D40", VA = "0x182AD2740")]
		private float CalcDepthInWater()
		{
			return 0f;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2AD2840", Offset = "0x2AD0E40", VA = "0x182AD2840", Slot = "29")]
		public bool IsInSwimmableWater()
		{
			return default(bool);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2AD28C0", Offset = "0x2AD0EC0", VA = "0x182AD28C0", Slot = "30")]
		public bool IsOnLand()
		{
			return default(bool);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2AD2940", Offset = "0x2AD0F40", VA = "0x182AD2940")]
		private void UpdateSwimmingState()
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2AD2B50", Offset = "0x2AD1150", VA = "0x182AD2B50")]
		public float GetDistanceToGround()
		{
			return 0f;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2AD2B80", Offset = "0x2AD1180", VA = "0x182AD2B80")]
		private VailActor.MoveStateSettings GetMoveSettings(VailActor.VailMoveMode mode)
		{
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2AD2BB0", Offset = "0x2AD11B0", VA = "0x182AD2BB0")]
		public void UpdateActorMovement(float deltaTime)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2AD3740", Offset = "0x2AD1D40", VA = "0x182AD3740")]
		private void UpdateFlightPathMovement(float deltaTime)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2AD3D80", Offset = "0x2AD2380", VA = "0x182AD3D80")]
		private void UpdateSurfacePathMovement(float deltaTime)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2AD4100", Offset = "0x2AD2700", VA = "0x182AD4100")]
		private void UpdateMoveSettings()
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2AD4190", Offset = "0x2AD2790", VA = "0x182AD4190")]
		public BoundsShape GetPathBounds()
		{
			return null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2AD4200", Offset = "0x2AD2800", VA = "0x182AD4200")]
		public void SetPathBounds(BoundsShape swimBounds, BoundsShape airBounds, BoundsShape groundBounds)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2AD4350", Offset = "0x2AD2950", VA = "0x182AD4350")]
		public float DistanceToPathBounds(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2AD4460", Offset = "0x2AD2A60", VA = "0x182AD4460")]
		private Vector3 FindRandomWaypointInBounds(MoveRandomBounds boundsType)
		{
			return default(Vector3);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2AD4730", Offset = "0x2AD2D30", VA = "0x182AD4730")]
		public void SetKeepAboveTerrain(bool keepAboveTerrain)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2AD4850", Offset = "0x2AD2E50", VA = "0x182AD4850")]
		public void SetNavGraphMask(GraphMask navGraphMask)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2AD4930", Offset = "0x2AD2F30", VA = "0x182AD4930")]
		public GraphMask GetNavGraphMask()
		{
			return default(GraphMask);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x17000026")]
		public bool UsePushApart
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2AD4A20", Offset = "0x2AD3020", VA = "0x182AD4A20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x17000027")]
		public float PushApartRadius
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x2AD4A30", Offset = "0x2AD3030", VA = "0x182AD4A30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x17000028")]
		public bool PushedByPlayer
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x2AD4A40", Offset = "0x2AD3040", VA = "0x182AD4A40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2AD4AC0", Offset = "0x2AD30C0", VA = "0x182AD4AC0")]
		public void PushApart(VailActor otherActor, float distSqr, float minDist)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2AD4D10", Offset = "0x2AD3310", VA = "0x182AD4D10")]
		private float GetDistanceFromCapsule(Vector3 capsulePos, float height, out Vector3 linePoint)
		{
			return 0f;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2AD4E50", Offset = "0x2AD3450", VA = "0x182AD4E50")]
		public void KeepAwayFromPlayer(Vector3 playerPos, float oldDistToPlayer)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2AD5030", Offset = "0x2AD3630", VA = "0x182AD5030")]
		public void PushAwayFromCapsule(Vector3 center, float height, float minDist, float maxPushDist = 1000f)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2AD5210", Offset = "0x2AD3810", VA = "0x182AD5210")]
		public void UpdateTransform(float deltaTime = 0f)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2AD55F0", Offset = "0x2AD3BF0", VA = "0x182AD55F0")]
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation, bool noRotationLimits = false)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2AD57E0", Offset = "0x2AD3DE0", VA = "0x182AD57E0")]
		public void SetSnapToTarget(bool active)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2AD58D0", Offset = "0x2AD3ED0", VA = "0x182AD58D0")]
		public bool EnsureAboveTerrain()
		{
			return default(bool);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2AD59C0", Offset = "0x2AD3FC0", VA = "0x182AD59C0")]
		public void SnapToTerrain()
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2AD5A80", Offset = "0x2AD4080", VA = "0x182AD5A80", Slot = "5")]
		public void OnAnimatorMove()
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2AD5B80", Offset = "0x2AD4180", VA = "0x182AD5B80")]
		public void AddKnockUpVelocity(Vector3 velocity)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2AD5BC0", Offset = "0x2AD41C0", VA = "0x182AD5BC0")]
		private void OnLanded(Vector3 oldVelocity)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2AD5CF0", Offset = "0x2AD42F0", VA = "0x182AD5CF0")]
		private void SetFalling(bool isFalling)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2AD5D40", Offset = "0x2AD4340", VA = "0x182AD5D40")]
		private void TickSmoothY(float deltaTime)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2AD5F40", Offset = "0x2AD4540", VA = "0x182AD5F40")]
		private void SnapToNavMesh(float randomOffset = 0f)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x17000029")]
		public bool UseNavMesh
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x2AD6520", Offset = "0x2AD4B20", VA = "0x182AD6520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x1700002A")]
		public bool HasPath
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x2AD6530", Offset = "0x2AD4B30", VA = "0x182AD6530")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00003318 File Offset: 0x00001518
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public bool IsFollowingTarget
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x2AD6540", Offset = "0x2AD4B40", VA = "0x182AD6540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2AD6550", Offset = "0x2AD4B50", VA = "0x182AD6550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x1700002C")]
		public float GetAnimatorSpeed
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x2AD6560", Offset = "0x2AD4B60", VA = "0x182AD6560")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x1700002D")]
		public Vector3 GetCurrentPathWaypoint
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x2AD6570", Offset = "0x2AD4B70", VA = "0x182AD6570")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2AD6590", Offset = "0x2AD4B90", VA = "0x182AD6590")]
		private Vector3 GetPathingPivotPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2AD66F0", Offset = "0x2AD4CF0", VA = "0x182AD66F0")]
		private void VerifySeeker()
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2AD6930", Offset = "0x2AD4F30", VA = "0x182AD6930")]
		public bool AllowSpawnInBase()
		{
			return default(bool);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2AD6980", Offset = "0x2AD4F80", VA = "0x182AD6980")]
		private float GetDistanceToMoveTargetSqr(Vector3 position, Vector3 targetPos)
		{
			return 0f;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2AD6A30", Offset = "0x2AD5030", VA = "0x182AD6A30")]
		private void UpdatePathState()
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2AD7510", Offset = "0x2AD5B10", VA = "0x182AD7510")]
		private void CheckWaypointReached()
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2AD7710", Offset = "0x2AD5D10", VA = "0x182AD7710")]
		private void UpdatePathMove()
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2AD79B0", Offset = "0x2AD5FB0", VA = "0x182AD79B0")]
		private void SetAnimatorMovementSpeed(SpeedRangeSet animationSpeedParam, float targetDistance)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2AD7AA0", Offset = "0x2AD60A0", VA = "0x182AD7AA0")]
		private void CheckForMovementProgress(float deltaTime)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2AD7CE0", Offset = "0x2AD62E0", VA = "0x182AD7CE0")]
		private void CheckSnapToNavMesh()
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2AD7DA0", Offset = "0x2AD63A0", VA = "0x182AD7DA0")]
		private void SetPathGoalRotation()
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2AD8180", Offset = "0x2AD6780", VA = "0x182AD8180")]
		private void EndPath()
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2AD81E0", Offset = "0x2AD67E0", VA = "0x182AD81E0")]
		private void ClearPath()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2AD8350", Offset = "0x2AD6950", VA = "0x182AD8350")]
		private void ResetWaypointProgress()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2AD8370", Offset = "0x2AD6970", VA = "0x182AD8370")]
		private void IncreasePathIndex()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2AD85B0", Offset = "0x2AD6BB0", VA = "0x182AD85B0")]
		private bool GotPathResult(Path result)
		{
			return default(bool);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2AD8A70", Offset = "0x2AD7070", VA = "0x182AD8A70")]
		private void OnNavMeshPathFound(Path result)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2AD91C0", Offset = "0x2AD77C0", VA = "0x182AD91C0")]
		private void OnNavMeshPathFoundAdd(Path result)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2AD9360", Offset = "0x2AD7960", VA = "0x182AD9360")]
		private void StartPathMove()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2AD9490", Offset = "0x2AD7A90", VA = "0x182AD9490")]
		private void CancelFindPath()
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2AD95F0", Offset = "0x2AD7BF0", VA = "0x182AD95F0")]
		private bool UseWorldPaths()
		{
			return default(bool);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2AD9720", Offset = "0x2AD7D20", VA = "0x182AD9720")]
		private void FindPath()
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2AD9DB0", Offset = "0x2AD83B0", VA = "0x182AD9DB0")]
		private void SetActivePathTarget(Vector3 targetPos, bool localAvoid = false)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2AD9DD0", Offset = "0x2AD83D0", VA = "0x182AD9DD0")]
		private int GetPathPointsCount()
		{
			return 0;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2AD9E50", Offset = "0x2AD8450", VA = "0x182AD9E50")]
		private bool IsLastPathPoint()
		{
			return default(bool);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2AD9EA0", Offset = "0x2AD84A0", VA = "0x182AD9EA0")]
		private Vector3 GetPathPointAtIndex(int index)
		{
			return default(Vector3);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2AD9FD0", Offset = "0x2AD85D0", VA = "0x182AD9FD0")]
		private void ReleasePath()
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2ADA180", Offset = "0x2AD8780", VA = "0x182ADA180")]
		public bool IsRelevantPathingTowardsPlayer()
		{
			return default(bool);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2ADA240", Offset = "0x2AD8840", VA = "0x182ADA240")]
		private bool IsEnemy(MonoBehaviourStimuli monoStimuli)
		{
			return default(bool);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2ADA420", Offset = "0x2AD8A20", VA = "0x182ADA420")]
		private void UpdateIsStrafing()
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2ADA810", Offset = "0x2AD8E10", VA = "0x182ADA810")]
		private Vector3 GetStrafeTargetDir(Vector3 goalDir)
		{
			return default(Vector3);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2ADAB50", Offset = "0x2AD9150", VA = "0x182ADAB50")]
		public void UpdateStrafeDir(Vector3 goalDir, float deltaTime)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2ADB030", Offset = "0x2AD9630", VA = "0x182ADB030")]
		public void ShowDebugPath()
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2ADB4B0", Offset = "0x2AD9AB0", VA = "0x182ADB4B0")]
		private void ApplyStatusEffects(IReadOnlyList<StatusEffect> infoStatusEffects, bool blocked = false)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2ADB690", Offset = "0x2AD9C90", VA = "0x182ADB690")]
		private float GetMultiplier(StatusEffectType type)
		{
			return 0f;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2ADB6D0", Offset = "0x2AD9CD0", VA = "0x182ADB6D0")]
		public void AddStatusEffect(StatusEffectType effectType, float lifetime)
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2ADB740", Offset = "0x2AD9D40", VA = "0x182ADB740")]
		public void RemoveStatusEffect(StatusEffectType effectType)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2ADB770", Offset = "0x2AD9D70", VA = "0x182ADB770")]
		private void UpdateStatusEffects()
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2ADB870", Offset = "0x2AD9E70", VA = "0x182ADB870")]
		private void UpdateTemperatureStatusEffects()
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2ADB920", Offset = "0x2AD9F20", VA = "0x182ADB920")]
		private void InitializeStatusEffectTypeList()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2ADB9F0", Offset = "0x2AD9FF0", VA = "0x182ADB9F0")]
		public bool HasStatusEffect(StatusEffectType statusEffectType)
		{
			return default(bool);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2ADBA90", Offset = "0x2ADA090", VA = "0x182ADBA90")]
		public List<Type> MapStimuliTypes(Type stimuliType)
		{
			return null;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2ADBD80", Offset = "0x2ADA380", VA = "0x182ADBD80")]
		public bool IsStimuliInRange(Vector3 position, float maxDistance, Type stimuliType, bool validate = false)
		{
			return default(bool);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2ADBF60", Offset = "0x2ADA560", VA = "0x182ADBF60")]
		public bool IsStimuliInRangeAngle(Vector3 position, float maxDistance, Type stimuliType, Vector3 forward, float maxAngle)
		{
			return default(bool);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2ADC290", Offset = "0x2ADA890", VA = "0x182ADC290")]
		public MonoBehaviourStimuli GetValidStimuliInRange(Vector3 position, float maxDistance, Type stimuliType)
		{
			return null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2ADC450", Offset = "0x2ADAA50", VA = "0x182ADC450")]
		internal bool IsValidStimuli(IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2ADC530", Offset = "0x2ADAB30", VA = "0x182ADC530")]
		internal float GetDistanceSqrToStimuli(MonoBehaviourStimuli stimuli)
		{
			return 0f;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2ADC5C0", Offset = "0x2ADABC0", VA = "0x182ADC5C0")]
		public void AddImmediateStimuli(ImmediateStimuli stimuli)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2ADC6C0", Offset = "0x2ADACC0", VA = "0x182ADC6C0")]
		public bool HasImmediateStimuli(Type stimuliType, out IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2ADC980", Offset = "0x2ADAF80", VA = "0x182ADC980")]
		private void ClearImmediateStimuli()
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2ADC9E0", Offset = "0x2ADAFE0", VA = "0x182ADC9E0")]
		private void UpdateActorRotation()
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2ADCDD0", Offset = "0x2ADB3D0", VA = "0x182ADCDD0")]
		private void UpdateAimAssist()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2ADD160", Offset = "0x2ADB760", VA = "0x182ADD160")]
		private Vector3 GetAlignToDir(bool allowPitch)
		{
			return default(Vector3);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2ADD3D0", Offset = "0x2ADB9D0", VA = "0x182ADD3D0")]
		private void UpdateAlignTo()
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2ADD820", Offset = "0x2ADBE20", VA = "0x182ADD820")]
		private void UpdateTargetDir()
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2ADDB80", Offset = "0x2ADC180", VA = "0x182ADDB80")]
		public float GetLocalYawAngle(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2ADDC20", Offset = "0x2ADC220", VA = "0x182ADDC20")]
		private float GetPitchAngle(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2ADDD40", Offset = "0x2ADC340", VA = "0x182ADDD40")]
		public void UpdateAnimatorTargetDir(Vector3 targetPosition)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2ADE080", Offset = "0x2ADC680", VA = "0x182ADE080")]
		private void UpdateAnimatorDirection(Vector3 goalDirection)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2ADE3A0", Offset = "0x2ADC9A0", VA = "0x182ADE3A0")]
		private void UpdateAnimatorStrafeDirection()
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2ADE4F0", Offset = "0x2ADCAF0", VA = "0x182ADE4F0")]
		private void SetDodgeDir(Vector3 instigatorPosition)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2ADE6E0", Offset = "0x2ADCCE0", VA = "0x182ADE6E0")]
		private void SetDirectionParamInt(int id, float localYaw)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2ADE750", Offset = "0x2ADCD50", VA = "0x182ADE750")]
		public static float GetVisionRangeMultiplier(bool wasRecentlySeen, float nightVision, MonoBehaviourStimuli targetStimuli)
		{
			return 0f;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2ADE9F0", Offset = "0x2ADCFF0", VA = "0x182ADE9F0")]
		public float GetVisionRange(bool wasRecentlySeen, float lookAngleToTarget, MonoBehaviourStimuli targetStimuli)
		{
			return 0f;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2ADEB30", Offset = "0x2ADD130", VA = "0x182ADEB30")]
		private static float GetLookAngleToTarget(Vector3 targetPos, Transform lookTransform, Vector3 localLookDir)
		{
			return 0f;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2ADECA0", Offset = "0x2ADD2A0", VA = "0x182ADECA0")]
		private bool RaycastSegment(Vector3 start, Vector3 dir, float distance, float radius)
		{
			return default(bool);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2ADEF20", Offset = "0x2ADD520", VA = "0x182ADEF20")]
		private bool DoVisionRaycast(Vector3 raySourcePosition, Vector3 targetDir, float visionRange, float radius, GameObject targetGo)
		{
			return default(bool);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2ADF460", Offset = "0x2ADDA60", VA = "0x182ADF460")]
		private void UpdateLastSeenLocation(MonoBehaviourStimuli monoBehaviourStimuli)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2ADF530", Offset = "0x2ADDB30", VA = "0x182ADF530")]
		private void AddToLastSeenStimuli(MonoBehaviourStimuli stimuli)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x2ADF680", Offset = "0x2ADDC80", VA = "0x182ADF680")]
		public bool TryGetLastSeen(Type searchType, out LastSeenStimuli result)
		{
			return default(bool);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x60002FD")]
		public bool CanSee<T>(T obj) where T : MonoBehaviourStimuli
		{
			return default(bool);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2ADF7D0", Offset = "0x2ADDDD0", VA = "0x182ADF7D0")]
		private bool CanSeeCached(MonoBehaviourStimuli targetStimuli)
		{
			return default(bool);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2ADFA40", Offset = "0x2ADE040", VA = "0x182ADFA40")]
		private bool CanSee(MonoBehaviourStimuli targetStimuli, bool wasRecentlySeen)
		{
			return default(bool);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2AE0410", Offset = "0x2ADEA10", VA = "0x182AE0410")]
		private void UpdateSeenCache(bool fullTick)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2AE0750", Offset = "0x2ADED50", VA = "0x182AE0750")]
		private void EvaluateSeenCache(float currentTime)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2AE0870", Offset = "0x2ADEE70", VA = "0x182AE0870")]
		private void UpdateActorStimuli()
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2AE09C0", Offset = "0x2ADEFC0", VA = "0x182AE09C0")]
		public VailActor()
		{
		}

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<VailActor.StateAnimSettings> _stateAnimatorSettings;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationParameter _parryState;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationParameter _parryLayer;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("These layers fully override the base layer, so skip triggering certain events.")]
		[SerializeField]
		private List<AnimationParameter> _animOverrideLayers;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly List<int> _animOverrideLayerIndices;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _isFemale;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private VailActor.AnimParam _scaredFloatParam;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private VailActor.AnimParam _angryFloatParam;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private VailActor.AnimParam _holdItemFloatParam;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private VailActor.AnimParam _fallingBoolParam;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private VailActor.AnimParam _landedBoolParam;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private VailActor.AnimParam _inWaterBoolParam;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private VailActor.AnimParam _aimWeaponBBoolParam;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private VailActor.AnimParam _cancelActionBoolParam;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private VailActor.AnimParam _speedFloatParam;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private VailActor.AnimParam _targetDirFloatParam;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private VailActor.AnimParam _targetDistanceFloatParam;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private VailActor.AnimParam _targetDistanceFloatXZParam;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private VailActor.AnimParam _targetLowParam;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private VailActor.AnimParam _pitchDirectionFloatParam;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private VailActor.AnimParam _alertedBoolParam;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private VailActor.AnimParam _inCombatBoolParam;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private VailActor.AnimParam _lookDirIntParam;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private AnimatorCullingMode _defaultAnimatorCulling;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private VailActor.IFootstepInterface _footstepInterface;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private sbyte[] _animStateTags;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[EventRef]
		private string _aggressiveIdleEvent;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _aggressiveMoveSpeed;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private bool _isPlayingIdleAudio;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x145")]
		[SerializeField]
		private bool _canCrouch;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x146")]
		[SerializeField]
		private bool _showCrouchGizmos;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float _crouchedHeight;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private float _standingHeight;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _isCrouched;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		private const float JumpSurfaceMaxNormalY = 0.707f;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		private const float LocalAvoidSurfaceMaxNormalY = 0.62f;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		[SerializeField]
		private float _jumpMinHeight;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private float _jumpCastRadius;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private float _jumpCastDistance;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private List<VailActor.AutoJump> _autoJumps;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool _hasJumpDown;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Collider[] OverlappingColliders;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<VailActor.SphereCastDebug> _debugSphereCasts;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		private VailActorTypeId _id;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		private VailController _controller;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private List<VailControllerOverride> _overrideControllers;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[SerializeField]
		private WorldSimController _worldSimController;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private StimuliGroupList _stimuliGroups;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private float _healthMax;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private ActorHealthVariations _healthVariation;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[Tooltip("Virtually increases health in coop. (Will reduce damage based on player count.)")]
		[SerializeField]
		private float _healthCoopMult;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private MonoBehaviourStimuli _actorStimuli;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private MonoBehaviourStimuli _capturedStimuli;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private CharacterController _characterController;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private VailActorLods _actorLods;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[FormerlySerializedAs("_actorOutfits")]
		[SerializeField]
		private VailActorVariations _actorVariations;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private AlignToGround _alignToGround;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private VailGiftManager _vailGiftManager;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private Transform _visualRoot;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[FormerlySerializedAs("_animatorTarget")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[SerializeField]
		private VailAnimEvents _animEvents;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		private VailLookAt _lookAt;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		private Attention _attention;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		[SerializeField]
		private DamageController _damageController;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[SerializeField]
		private RagdollManager _ragdollManager;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[SerializeField]
		private CharacterBloodRevealProxy _bloodReveal;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[SerializeField]
		private CharacterDirtReveal _dirtReveal;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		[SerializeField]
		private VailActorStateFX _stateFx;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		[SerializeField]
		private DismembermentController _dismembermentController;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[SerializeField]
		private StaggerController _staggerController;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[SerializeField]
		private MonoBehaviour _armorSystem;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		[SerializeField]
		private InventoryManager _inventoryManager;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[SerializeField]
		private ActorMemory _actorMemory;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[SerializeField]
		private GameObject _pusherObject;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		[SerializeField]
		private GameObject _livingObject;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		[SerializeField]
		private GameObject _dyingObject;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		[SerializeField]
		private GameObject _deadObject;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		[SerializeField]
		private GameObject _grassPusher;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		[SerializeField]
		private GameObject _skinningPickup;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		private GameObject _lootSpawnerObject;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		[SerializeField]
		private VailActorNetworked _actorNetworked;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		[SerializeField]
		private WaterLevelSensor _waterLevelSensor;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		[SerializeField]
		private Transform _dragAllyTransform;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		[SerializeField]
		private GameObject _droppedHelicopter;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private RescueDragStimuli _rescueDragStimuli;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private bool _hasWaterLevelSensor;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D1")]
		private bool _helicopterHeld;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject _droppedHelicopterInstance;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		[SerializeField]
		private State _currentState;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		[SerializeField]
		private StateProfileManager _stateProfileManager;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private Group _activeGroup;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private Group _nextInSequenceSourceGroup;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private Thought _activeThought;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private Thought _lastThought;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private float _activeThoughtStartTime;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private bool _thoughtHasPersistentStimuli;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32D")]
		private bool _pickupInteractCompleted;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32E")]
		private bool _shouldSwitchState;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private Priority _lastPriority;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private float _currentStateStartTime;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		private bool _isCombatAware;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private float _combatAwareStateStartTime;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		private bool _cleaningAction;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x345")]
		private bool _actionFacesStimuli;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private float _overrideSetTime;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private readonly VailActor.ActiveStimuliInfo _activeStimuli;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private MaeSequence _activeActionAsset;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private MaeSequence _activeActionInstance;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private float _capsuleRadius;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		private float _capsuleHeight;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private Vector3 _capsuleCenter;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
		private Vector3 _originalScale;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private float _actorScaleMult;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38C")]
		private Vector3 _initialVisualRootPos;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private float _armorLevel;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
		private float _currentWetness;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private int _tickOffset;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
		private float _fullTickDeltaTime;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private WorldSimActor _worldSimActor;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private bool _registeredWithWorld;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B4")]
		private int _worldSimUniqueId;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		[SerializeField]
		private bool _allowDeactivate;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3BC")]
		[SerializeField]
		private float _activeDistance;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		[SerializeField]
		private float _moveSpeedLite;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
		[SerializeField]
		private bool _useNearbyInfluences;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C5")]
		[SerializeField]
		private bool _persistentStats;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C6")]
		[SerializeField]
		private bool _showWireDistances;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C7")]
		[SerializeField]
		private bool _showSolidDistances;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		[SerializeField]
		private float _meleeKnockbackDistance;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
		[SerializeField]
		private float _meleeKnockbackTime;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		[SerializeField]
		private float _shotgunKnockbackDistance;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
		[SerializeField]
		private float _shotgunKnockbackTime;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		[SerializeField]
		private float _explosionKnockbackDistanceMax;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
		[SerializeField]
		private float _explosionKnockbackTimeMax;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		[SerializeField]
		private bool _useComboEnders;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
		[SerializeField]
		private float _staggerRecoverRate;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		[SerializeField]
		private float _staggerPerHit;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
		[SerializeField]
		private float _staggeredAmount;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		[SerializeField]
		private bool _onlyStaggeredByPlayer;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F1")]
		[SerializeField]
		private bool _knockdownEnabled;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F4")]
		[SerializeField]
		private float _knockdownRecoverRate;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		[SerializeField]
		private float _knockdownAmount;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3FC")]
		[SerializeField]
		private VailActor.HitReactType _hitReactType;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		[SerializeField]
		private bool _hasMultipleBodies;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x404")]
		[SerializeField]
		private float _hitReactCooldown;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		[Tooltip("Melee weapon weight for no react")]
		[SerializeField]
		private float _minHitReactWeight;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40C")]
		[Tooltip("<= this melee weapon weight for only additive reacts")]
		[SerializeField]
		private float _additiveReactWeight;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _lightHeadHitReactChance;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x414")]
		[SerializeField]
		private bool _hasInjuredState;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		[SerializeField]
		private float _dyingHealthRecover;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
		[SerializeField]
		private bool _onlyKilledByPlayer;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		[SerializeField]
		private float _teamDamage;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x424")]
		[SerializeField]
		private float _hitBehindDamageMult;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		[SerializeField]
		private float _bleedingFactor;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42C")]
		[SerializeField]
		private float _electricityFactor;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		[SerializeField]
		private float _burningFactor;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x434")]
		[SerializeField]
		private float _shotgunFactor;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		[SerializeField]
		private float _explosivesFactor;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		[SerializeField]
		private VailStatsManager _statsManager;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		[SerializeField]
		private VailTraitDefinition _traitsDefinition;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		[SerializeField]
		private List<DamageStatAdjustment> _impactAdjustments;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		[SerializeField]
		private EventStimuli _onHitEvent;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		[SerializeField]
		private bool _skipAngerIfNotEnemy;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x464")]
		private Vector3 _animatorMoveDelta;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private Quaternion _animatorRotationDelta;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private Vector3 _worldGoalPosition;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48C")]
		private float _yawRescale;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private bool _isFalling;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x494")]
		private float _treeAttachRadius;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private Vector3 _treeAttachPos;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private IVailSpawner _spawner;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		[SerializeField]
		private VailActor.MoveStateSettings _defaultMoveSettings;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		[SerializeField]
		private bool _showSwim;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B9")]
		[SerializeField]
		private bool _showFly;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
		[SerializeField]
		private float _swimWaterDepth;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		[SerializeField]
		private VailActor.MoveStateSettings _swimMoveSettings;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		[SerializeField]
		private VailActor.MoveStateSettings _flyMoveSettings;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		[SerializeField]
		private float _stepUpTraceHeight;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
		[SerializeField]
		private float _smoothingSpeed;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		[SerializeField]
		private float _smoothingMaxDelta;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4DC")]
		[SerializeField]
		private float _drownDepth;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		[SerializeField]
		private bool _autoStrafe;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E1")]
		[SerializeField]
		private bool _stoppedByPlayer;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E2")]
		[SerializeField]
		private bool _pushedByPlayer;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E3")]
		[SerializeField]
		private bool _usePushApart;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E4")]
		[SerializeField]
		private float _pushApartRadius;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		[SerializeField]
		private SurfaceMover _surfaceMover;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		[SerializeField]
		private bool _useActorMover;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		[SerializeField]
		private ActorMover _actorMover;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		private float _currentDirectionValue;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x504")]
		private Vector3 _currentStrafeDir;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		private bool _isStrafing;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x511")]
		private bool _waitingToStartStrafe;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x512")]
		private bool _strafeAnimActive;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x513")]
		private bool _alignToTarget;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x514")]
		private bool _snapToTargetActive;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x515")]
		private bool _noRootMotion;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private Transform _alignToTargetTransform;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private float _alignTargetYaw;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x524")]
		private Quaternion _goalRotation;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x534")]
		[SerializeField]
		private Vector2 _minMaxScale;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		[SerializeField]
		private Transform _leftHandTransform;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		[SerializeField]
		private List<NamedGameObject> _namedObjects;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		private readonly Dictionary<string, Stat> _statNameMap;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		private List<Group> _nextInSequence;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		private bool _isFollowingSequence;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x574")]
		private int _sequenceIndex;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		private readonly Dictionary<Group, float> _cooldowns;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		private readonly Dictionary<Condition, float> _randomCooldowns;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<Group> CooldownKeysToRemove;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<MonoBehaviourStimuli> _nearStimuliList;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		private readonly List<string> _verboseLog;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		private bool _isInitialized;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x594")]
		private float _gameSettingsDamageMultiplier;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private float _gameSettingsAngerMultiplier;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59C")]
		private bool _isDead;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59D")]
		private bool _isBodyBurning;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59E")]
		private bool _forceDisableLookAt;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59F")]
		private bool _networkActive;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		private float _lastAlertedTime;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A4")]
		private bool _alertAction;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		private int _nearbyFriendCount;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5AC")]
		private float _nextFriendCountCheckTime;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		private bool _damageEnabled;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B4")]
		private VailActor.PreyGrabType _preyGrabActive;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		private VailActor _preyActor;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		private Transform _preyAttachTransformUs;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		private Transform _preyAttachTransformThem;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D4")]
		private float _nextSpringTrapTime;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		private float _hitFallOffTreeTime;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5DC")]
		private bool _robbyInjured;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		public const string CloseColor = "</color>";

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		[SerializeField]
		private float _aimAssistRotateRate;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E4")]
		[SerializeField]
		private float _aimAssistActiveAngle;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		[SerializeField]
		private bool _canAttackStructures;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		[SerializeField]
		private List<MeleeWeapon> _meleeWeapons;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		[SerializeField]
		private List<VailActor.EquipItem> _equipItems;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		[SerializeField]
		private bool _alwaysEquipped;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x601")]
		private bool _meleeIsActive;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x604")]
		private float _staggerLevel;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		private float _knockdownLevel;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60C")]
		private float _damageByPlayer;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		private int _dismemberedParts;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x614")]
		private Vector3 _lastImpactSenderDir;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		private float _lastHitReactTime;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x624")]
		private int _hitReactActiveFrame;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		private readonly List<DamageReceivedStimuli> _damageReceivedStimuliList;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		private const string ArmId = "arm/";

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		private const string LegId = "leg/";

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		private const string RightId = "right/";

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		private const string LeftId = "left/";

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		private const string RightArmId = "arm/right/";

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		private const string LeftArmId = "arm/left/";

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		private const string RightLegId = "leg/right/";

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		private const string LeftLegId = "leg/left/";

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int FatalHitHash;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static int DeathHash;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int HitDirHash;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static int BrokenLeftArmHash;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static int BrokenRightArmHash;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static int BrokenLeftLegHash;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static int BrokenRightLegHash;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static int DismemberLeftArmHash;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static int DismemberRightArmHash;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static int DismemberLeftLegHash;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static int DismemberRightLegHash;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static int BlockHitHash;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		private bool _resetBlockHit;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x634")]
		private VailActor.AnimParam _hitElectrocuteParam;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63C")]
		private VailActor.AnimParam _electrocutedParam;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x644")]
		private VailActor.AnimParam _hitExplosionParam;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64C")]
		private VailActor.AnimParam _hitShotgunParam;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x654")]
		private VailActor.AnimParam _hitStaggerParam;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65C")]
		private VailActor.AnimParam _hitKnockdownParam;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x664")]
		private VailActor.AnimParam _hitAdditiveParam;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66C")]
		private VailActor.AnimParam _attackImpactParam;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x674")]
		private VailActor.AnimParam _hitFrontBodyParam;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67C")]
		private VailActor.AnimParam _hitBackBodyParam;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x684")]
		private VailActor.AnimParam _hitArmParam;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68C")]
		private VailActor.AnimParam _hitLegParam;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x694")]
		private VailActor.AnimParam _hitStomachParam;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69C")]
		private VailActor.AnimParam _hitHeadParam;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A4")]
		private VailActor.AnimParam _hitBodyParam;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6AC")]
		private VailActor.AnimParam _hitMeleeParam;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B4")]
		private VailActor.AnimParam _hitProjectileParam;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6BC")]
		private bool _hasInventory;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6BD")]
		private bool _stashedEquipped;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
		private int _equippedMaskClient;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C4")]
		[SerializeField]
		private bool _useLocalAvoidance;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
		[SerializeField]
		private VailActor.AvoidCast _avoidCast;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6CC")]
		[SerializeField]
		private float _avoidCastDistance;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
		[SerializeField]
		private float _avoidCastDistanceRun;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D4")]
		[SerializeField]
		private float _avoidOffsetDistance;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
		[SerializeField]
		private float _maxGoalAngleDiff;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
		private MoveToParams _moveToParams;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
		private AlignToParams _alignToParams;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
		private SnapToParams _snapToParams;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
		private Vector3 _snapToStartPosition;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x704")]
		private Quaternion _snapToStartRotation;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x714")]
		private bool _snapUseStaticEnd;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x718")]
		private Vector3 _snapToEndPosition;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x724")]
		private Quaternion _snapToEndRotation;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x734")]
		private Vector3 _snapJumpVel;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x740")]
		private float _snapJumpGravity;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x748")]
		private Transform _reservedLocationTarget;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x750")]
		private bool _hasMoveToTarget;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x758")]
		private GameObject _worldGoalLocator;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x760")]
		private float _lastCloseAttack;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x768")]
		private readonly VailActor.MoveState _moveState;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x770")]
		private SurfacePathParams _surfacePathParams;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x778")]
		private FlightPathParams _flightParams;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x780")]
		private float _updateFlySpeedTime;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x788")]
		private Transform _transform;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x790")]
		private CeilingWalkArea _ceilingWalkArea;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x798")]
		private float _smoothingDeltaY;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79C")]
		private float _keepRotation;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
		private float _keepRotationTime;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A4")]
		private Quaternion _keepRotationStartRot;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B4")]
		private Quaternion _keepRotationEndRot;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		private const float NavGraphMarginY = 2f;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C4")]
		[FormerlySerializedAs("useNavMesh")]
		[SerializeField]
		private bool _useNavMesh;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C8")]
		[SerializeField]
		private Seeker _seeker;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
		[SerializeField]
		private float _pathNextDistance;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D4")]
		[SerializeField]
		private float _pathBypassNextDistance;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D8")]
		[SerializeField]
		private VailPath _vailPath;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E0")]
		[SerializeField]
		private Transform _pathingPivot;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
		[SerializeField]
		private FlightPathMover _flightPathMover;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
		private bool _moveTargetIsReservedLocation;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
		private Transform _moveToTarget;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x800")]
		private bool _hasPath;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x801")]
		private bool _waitingForPath;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x804")]
		private float _findPathStartTime;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80C")]
		private int _pathIndex;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x810")]
		private Vector3 _activePathTargetPos;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81C")]
		private bool _usingLocalAvoidTarget;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x820")]
		private float _timeMovementStuck;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x824")]
		private float _timeWithoutWaypointProgress;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x828")]
		private List<Vector3> _pathNodes;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x830")]
		private Path _activeNavMeshPath;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x838")]
		private Vector3 _stoppedPositionToCheck;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x844")]
		private float _distanceFromTarget;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x848")]
		private float _distanceFromStop;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84C")]
		private float _distanceToNextWaypoint;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x850")]
		private float _closestDistanceToNextWaypoint;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x854")]
		private float _currentAnimatorSpeed;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x858")]
		private int _speedFrame;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x860")]
		private VailWorldPaths.WorldPathMove _worldPathMove;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x868")]
		private Vector3 _moveToTargetLastPos;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x874")]
		private int _worldPathNodeStart;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x878")]
		private int _worldPathNodeEnd;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x880")]
		private readonly StatusEffectManager _statusEffectManager;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x888")]
		private readonly List<int> _statusEffectAmounts;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x890")]
		private readonly List<ImmediateStimuli> _immediateStimuli;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x898")]
		private Type _mappedGroup;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A0")]
		private readonly List<Type> _mappedTypes;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A8")]
		private readonly List<Type> _singleType;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		private const float CanSeeBufferTime = 2f;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B0")]
		[SerializeField]
		private Transform _visionHeadJoint;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B8")]
		[SerializeField]
		[FormerlySerializedAs("_defaultSweepAngle")]
		[Tooltip("Max angle from center actor can see")]
		private float _visionPeripheralFov;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8BC")]
		[Tooltip("Focus angle in which max vision range is active")]
		[SerializeField]
		[FormerlySerializedAs("_defaultSweepAngle")]
		private float _visionFocusFov;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C0")]
		[SerializeField]
		[Tooltip("Fow far can this actor can see within focusFOV")]
		[FormerlySerializedAs("_defaultRange")]
		private float _visionFocusRange;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C4")]
		[FormerlySerializedAs("_defaultRange")]
		[SerializeField]
		private float _visionPeripheralRange;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C8")]
		[SerializeField]
		[FormerlySerializedAs("_visionAlertedRangeMult")]
		private float _visionAlertMult;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8CC")]
		[FormerlySerializedAs("_localLookAxis")]
		[SerializeField]
		private Vector3 _visionLocalAxis;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D8")]
		[SerializeField]
		private float _visionMinCastRadius;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8DC")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _nightVision;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E0")]
		private readonly Dictionary<Type, LastSeenStimuli> _lastSeenStimuliDict;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E8")]
		private readonly List<MonoBehaviourStimuli> _recentlySeenStimuli;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8F0")]
		private readonly List<float> _recentlySeenTimes;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8F8")]
		private RaycastHit _hitBuffer;

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		[Serializable]
		private class StateAnimSettings
		{
			// Token: 0x06000305 RID: 773 RVA: 0x00003630 File Offset: 0x00001830
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x2AF9740", Offset = "0x2AF7D40", VA = "0x182AF9740")]
			private Color GetStateButtonColor()
			{
				return default(Color);
			}

			// Token: 0x06000306 RID: 774 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x2AF97D0", Offset = "0x2AF7DD0", VA = "0x182AF97D0")]
			private IEnumerable GetStateTreeView()
			{
				return null;
			}

			// Token: 0x06000307 RID: 775 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x2AF9810", Offset = "0x2AF7E10", VA = "0x182AF9810")]
			private IEnumerable AnimStateParameters()
			{
				return null;
			}

			// Token: 0x06000308 RID: 776 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x2AF9860", Offset = "0x2AF7E60", VA = "0x182AF9860")]
			private IEnumerable AnimVarParameters()
			{
				return null;
			}

			// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public StateAnimSettings()
			{
			}

			// Token: 0x0400027D RID: 637
			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public State _state;

			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			public AnimationParameter _stateId;

			// Token: 0x0400027F RID: 639
			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[SerializeField]
			public AnimationParameter _paramId;

			// Token: 0x04000280 RID: 640
			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[SerializeField]
			public bool _snapToGround;
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		public readonly struct AnimParam
		{
			// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x2AF98B0", Offset = "0x2AF7EB0", VA = "0x182AF98B0")]
			public AnimParam(AnimationParameter param, Animator animator)
			{
			}

			// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x2AF98E0", Offset = "0x2AF7EE0", VA = "0x182AF98E0")]
			public void SetBool(bool value, Animator animator)
			{
			}

			// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2AF9920", Offset = "0x2AF7F20", VA = "0x182AF9920")]
			public void SetFloat(float value, Animator animator)
			{
			}

			// Token: 0x0600030D RID: 781 RVA: 0x00003648 File Offset: 0x00001848
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x2AF9950", Offset = "0x2AF7F50", VA = "0x182AF9950")]
			public float GetFloat(Animator animator)
			{
				return 0f;
			}

			// Token: 0x04000281 RID: 641
			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly int Id;

			// Token: 0x04000282 RID: 642
			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public readonly bool Exists;
		}

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		public interface IFootstepInterface
		{
			// Token: 0x0600030E RID: 782
			[Token(Token = "0x600030E")]
			void PlayLandSound(Vector3 position, float fallSpeed);
		}

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		[Serializable]
		private class AutoJump
		{
			// Token: 0x0600030F RID: 783 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x2AF99D0", Offset = "0x2AF7FD0", VA = "0x182AF99D0")]
			private IEnumerable AnimVarParameters()
			{
				return null;
			}

			// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x2AF9A20", Offset = "0x2AF8020", VA = "0x182AF9A20")]
			public AutoJump()
			{
			}

			// Token: 0x04000283 RID: 643
			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool _enabled;

			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float _height;

			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float _castDistance;

			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool _isJumpDown;

			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Minimum animator speed 0-1 for this jump type to activate")]
			public float _jumpMinSpeed;

			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationParameter _animParam;
		}

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		private class SphereCastDebug
		{
			// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x2AF9A30", Offset = "0x2AF8030", VA = "0x182AF9A30")]
			public void DrawDebugGizmos()
			{
			}

			// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x2AF9B40", Offset = "0x2AF8140", VA = "0x182AF9B40")]
			public SphereCastDebug(Vector3 inStart, Vector3 inEnd, float inRadius, bool hit)
			{
			}

			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 _start;

			// Token: 0x0400028A RID: 650
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 _end;

			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _radius;

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Color _color;
		}

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		private enum HitReactType
		{
			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			NoAdditive,
			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			AdditiveIfTagged,
			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			AlwaysAdditive,
			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			AlwaysAdditiveNoLocation
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		private enum PreyGrabType
		{
			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			None,
			// Token: 0x04000294 RID: 660
			[Token(Token = "0x4000294")]
			VailActor,
			// Token: 0x04000295 RID: 661
			[Token(Token = "0x4000295")]
			Transform
		}

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		[Serializable]
		private class EquipItem
		{
			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000313 RID: 787 RVA: 0x00003660 File Offset: 0x00001860
			[Token(Token = "0x1700002E")]
			public int ItemId
			{
				[Token(Token = "0x6000313")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000314 RID: 788 RVA: 0x00003678 File Offset: 0x00001878
			[Token(Token = "0x1700002F")]
			public bool CanStash
			{
				[Token(Token = "0x6000314")]
				[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000315 RID: 789 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2AF9B90", Offset = "0x2AF8190", VA = "0x182AF9B90")]
			private IEnumerable AnimVarParameters()
			{
				return null;
			}

			// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x2AF9BE0", Offset = "0x2AF81E0", VA = "0x182AF9BE0")]
			public void SetActive(bool value, VailActor actor)
			{
			}

			// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public EquipItem()
			{
			}

			// Token: 0x04000296 RID: 662
			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[ItemIdPicker(true)]
			[SerializeField]
			private int _itemId;

			// Token: 0x04000297 RID: 663
			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject _gameObject;

			// Token: 0x04000298 RID: 664
			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _canStash;

			// Token: 0x04000299 RID: 665
			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationParameter _animParam;
		}

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		private enum AvoidCast
		{
			// Token: 0x0400029B RID: 667
			[Token(Token = "0x400029B")]
			Sphere,
			// Token: 0x0400029C RID: 668
			[Token(Token = "0x400029C")]
			Ray
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		private enum VailMoveMode
		{
			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			None,
			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			Ground,
			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			Swimming,
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			Flying
		}

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		[Serializable]
		public class MoveStateSettings
		{
			// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2AF9D40", Offset = "0x2AF8340", VA = "0x182AF9D40")]
			public MoveStateSettings()
			{
			}

			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float _turnSpeed;

			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float _directionBlendSpeed;

			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float _directionScale;

			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool _allowPitchRotation;

			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float _pitchUpMax;

			// Token: 0x040002A7 RID: 679
			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float _pitchDownMax;

			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float _pitchTurnSpeed;

			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool _keepAboveTerrain;

			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float _minDistAboveTerrain;

			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool _swimOnTopOfWater;

			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float _maxBelowWater;

			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float _gravityScale;

			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float _minFallSpeed;

			// Token: 0x040002AF RID: 687
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float _maxFallSpeed;

			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector2 _speedRange;

			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool _alwaysClampToBounds;

			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public BoundsShape _pathBounds;
		}

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		private class MoveState
		{
			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000319 RID: 793 RVA: 0x00003690 File Offset: 0x00001890
			[Token(Token = "0x17000030")]
			public bool OnGround
			{
				[Token(Token = "0x6000319")]
				[Address(RVA = "0x9D9870", Offset = "0x9D7E70", VA = "0x1809D9870")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600031A RID: 794 RVA: 0x000036A8 File Offset: 0x000018A8
			[Token(Token = "0x17000031")]
			public bool SideCollision
			{
				[Token(Token = "0x600031A")]
				[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600031B RID: 795 RVA: 0x000036C0 File Offset: 0x000018C0
			[Token(Token = "0x17000032")]
			public Vector3 Position
			{
				[Token(Token = "0x600031B")]
				[Address(RVA = "0x1766460", Offset = "0x1764A60", VA = "0x181766460")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600031C RID: 796 RVA: 0x000036D8 File Offset: 0x000018D8
			[Token(Token = "0x17000033")]
			public Quaternion Rotation
			{
				[Token(Token = "0x600031C")]
				[Address(RVA = "0x2AF9DE0", Offset = "0x2AF83E0", VA = "0x182AF9DE0")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x0600031D RID: 797 RVA: 0x000036F0 File Offset: 0x000018F0
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x2AF9EA0", Offset = "0x2AF84A0", VA = "0x182AF9EA0")]
			public bool AllowPitchRotation()
			{
				return default(bool);
			}

			// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x2AF9EC0", Offset = "0x2AF84C0", VA = "0x182AF9EC0")]
			public void StartKnockBack(float distance, Vector3 dir, float duration)
			{
			}

			// Token: 0x0600031F RID: 799 RVA: 0x00003708 File Offset: 0x00001908
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x2AF9EF0", Offset = "0x2AF84F0", VA = "0x182AF9EF0")]
			private Vector3 UpdateKnockBack(float deltaTime)
			{
				return default(Vector3);
			}

			// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x2AFA0A0", Offset = "0x2AF86A0", VA = "0x182AFA0A0")]
			public void SnapToFaceDirection(Vector3 faceDir, float duration)
			{
			}

			// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x2AFA100", Offset = "0x2AF8700", VA = "0x182AFA100")]
			private void UpdateSnapToDirection(float deltaTime)
			{
			}

			// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x2AFA180", Offset = "0x2AF8780", VA = "0x182AFA180")]
			public void Initialize(Transform tr)
			{
			}

			// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x2AFA2A0", Offset = "0x2AF88A0", VA = "0x182AFA2A0")]
			private void SetOnGround(VailActor actor, bool newValue)
			{
			}

			// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x2AFA390", Offset = "0x2AF8990", VA = "0x182AFA390")]
			public void ClearFalling()
			{
			}

			// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x2AFA3E0", Offset = "0x2AF89E0", VA = "0x182AFA3E0")]
			public void ClearVelocity()
			{
			}

			// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x2AFA400", Offset = "0x2AF8A00", VA = "0x182AFA400")]
			public void AddFallingVelocity(Vector3 addVelocity)
			{
			}

			// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x2AFA510", Offset = "0x2AF8B10", VA = "0x182AFA510")]
			private void UpdateFalling(float deltaTime, float swimWaterDepth, float gravityScale)
			{
			}

			// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x2AFA7B0", Offset = "0x2AF8DB0", VA = "0x182AFA7B0")]
			public void UpdateWaterDepth(VailActor actor)
			{
			}

			// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x2AFA970", Offset = "0x2AF8F70", VA = "0x182AFA970")]
			public void UpdateMoveMode(VailActor actor)
			{
			}

			// Token: 0x0600032A RID: 810 RVA: 0x00003720 File Offset: 0x00001920
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x2AFAA40", Offset = "0x2AF9040", VA = "0x182AFAA40")]
			private bool StepUp(ref Vector3 position, VailActor actor)
			{
				return default(bool);
			}

			// Token: 0x0600032B RID: 811 RVA: 0x00003738 File Offset: 0x00001938
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x2AFADB0", Offset = "0x2AF93B0", VA = "0x182AFADB0")]
			public float DistanceToGround(float maxDistance = 5f)
			{
				return 0f;
			}

			// Token: 0x0600032C RID: 812 RVA: 0x00003750 File Offset: 0x00001950
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x2AFB0C0", Offset = "0x2AF96C0", VA = "0x182AFB0C0")]
			private float ClampPitch(float pitch)
			{
				return 0f;
			}

			// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x2AFB120", Offset = "0x2AF9720", VA = "0x182AFB120")]
			public void ClampToBounds(BoundsShape boundsShape)
			{
			}

			// Token: 0x0600032E RID: 814 RVA: 0x00003768 File Offset: 0x00001968
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			public float Yaw()
			{
				return 0f;
			}

			// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x2AFB220", Offset = "0x2AF9820", VA = "0x182AFB220")]
			public void AddYaw(float deltaYaw)
			{
			}

			// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x2AFB230", Offset = "0x2AF9830", VA = "0x182AFB230")]
			public void RotateTowards(Vector3 targetEuler, float maxYawDelta, float maxPitchDelta)
			{
			}

			// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x2AFB3B0", Offset = "0x2AF99B0", VA = "0x182AFB3B0")]
			public void TickRotation(Vector3 targetEuler, float deltaTime)
			{
			}

			// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x2AFB400", Offset = "0x2AF9A00", VA = "0x182AFB400")]
			public void SetRotation(Vector3 euler, bool noAxisConstraints)
			{
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x2AFB420", Offset = "0x2AF9A20", VA = "0x182AFB420")]
			public void ClampRotationAxes()
			{
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2040020", Offset = "0x203E620", VA = "0x182040020")]
			public void SetPosition(Vector3 newPosition)
			{
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x2AFB4B0", Offset = "0x2AF9AB0", VA = "0x182AFB4B0")]
			public void SetPositionAndRotation(Vector3 newPosition, Quaternion newRotation, bool noAxisConstraints)
			{
			}

			// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2AFB510", Offset = "0x2AF9B10", VA = "0x182AFB510")]
			public void AdjustPosition(Vector3 delta)
			{
			}

			// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2AFB570", Offset = "0x2AF9B70", VA = "0x182AFB570")]
			public void RetainRootVelocity()
			{
			}

			// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2AFB5B0", Offset = "0x2AF9BB0", VA = "0x182AFB5B0")]
			public void Tick(Vector3 moveDelta, VailActor actor, float deltaTime)
			{
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x2AFBAD0", Offset = "0x2AFA0D0", VA = "0x182AFBAD0")]
			private void Move(Vector3 moveDelta, VailActor actor, float deltaTime)
			{
			}

			// Token: 0x0600033A RID: 826 RVA: 0x00003780 File Offset: 0x00001980
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x2AFC1C0", Offset = "0x2AFA7C0", VA = "0x182AFC1C0")]
			public bool KeepAboveTerrain()
			{
				return default(bool);
			}

			// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x2AFC230", Offset = "0x2AFA830", VA = "0x182AFC230")]
			public MoveState()
			{
			}

			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 _position;

			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 _rotationEuler;

			// Token: 0x040002B5 RID: 693
			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 _lastVelocity;

			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public VailActor.VailMoveMode _moveMode;

			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float _depthInWater;

			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 _lastWaterCheckPos;

			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool _sideCollision;

			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			private bool _onGround;

			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private Vector3 _fallingVelocity;

			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float _minDistAboveTerrain;

			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public VailActor.MoveStateSettings _settings;

			// Token: 0x040002BE RID: 702
			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private TrackRootVelocity _velocityTracker;

			// Token: 0x040002BF RID: 703
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Vector3 _knockBackDir;

			// Token: 0x040002C0 RID: 704
			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private float _knockBackDistance;

			// Token: 0x040002C1 RID: 705
			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private float _knockBackDuration;

			// Token: 0x040002C2 RID: 706
			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private float _knockBackTime;

			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private float _snapToDirectionTime;

			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private float _snapToDirectionYaw;

			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private float _snapToDirectionStartYaw;

			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private float _snapToDirectionDuration;
		}

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		[Serializable]
		private class ActiveStimuliInfo
		{
			// Token: 0x17000034 RID: 52
			// (get) Token: 0x0600033C RID: 828 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x17000034")]
			public IStimuli Stimuli
			{
				[Token(Token = "0x600033C")]
				[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x0600033D RID: 829 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x17000035")]
			public MonoBehaviourStimuli MonoStimuli
			{
				[Token(Token = "0x600033D")]
				[Address(RVA = "0x2AFC3B0", Offset = "0x2AFA9B0", VA = "0x182AFC3B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x0600033E RID: 830 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x17000036")]
			public MonoBehaviourStimuli SourceStimuli
			{
				[Token(Token = "0x600033E")]
				[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x0600033F RID: 831 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x17000037")]
			public Transform Transform
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000340 RID: 832 RVA: 0x00003798 File Offset: 0x00001998
			[Token(Token = "0x17000038")]
			public bool IsActive
			{
				[Token(Token = "0x6000340")]
				[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000341 RID: 833 RVA: 0x000037B0 File Offset: 0x000019B0
			[Token(Token = "0x17000039")]
			public bool HasPosition
			{
				[Token(Token = "0x6000341")]
				[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x2AFC430", Offset = "0x2AFAA30", VA = "0x182AFC430")]
			public void Init(IStimuli stimuli)
			{
			}

			// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x2AFC830", Offset = "0x2AFAE30", VA = "0x182AFC830")]
			public void Clear()
			{
			}

			// Token: 0x06000344 RID: 836 RVA: 0x000037C8 File Offset: 0x000019C8
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x2AFC8F0", Offset = "0x2AFAEF0", VA = "0x182AFC8F0")]
			public Vector3 Position(bool checkSource = false)
			{
				return default(Vector3);
			}

			// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x2AFCB10", Offset = "0x2AFB110", VA = "0x182AFCB10")]
			public void Validate(VailActor actor)
			{
			}

			// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x2AFCD60", Offset = "0x2AFB360", VA = "0x182AFCD60")]
			private void TransferOrClear()
			{
			}

			// Token: 0x06000347 RID: 839 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x2AFD160", Offset = "0x2AFB760", VA = "0x182AFD160")]
			public string GetLog()
			{
				return null;
			}

			// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ActiveStimuliInfo()
			{
			}

			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool _active;

			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform _transform;

			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 _position;

			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IStimuli _stimuli;

			// Token: 0x040002CB RID: 715
			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MonoBehaviourStimuli _stimuliSource;

			// Token: 0x040002CC RID: 716
			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Type _stimuliType;

			// Token: 0x040002CD RID: 717
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool _hasPosition;
		}
	}
}
