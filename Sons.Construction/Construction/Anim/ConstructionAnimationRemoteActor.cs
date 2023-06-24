using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Multiplayer.Client;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	[AddComponentMenu("Sons/Construction/Anim/ConstructionAnimationRemoteActor")]
	public class ConstructionAnimationRemoteActor : MonoBehaviour, IConstructionAnimationActor
	{
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700044F")]
		public Transform MainTr
		{
			[Token(Token = "0x60014B0")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014B1")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000450")]
		public Transform LookTr
		{
			[Token(Token = "0x60014B2")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014B3")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000451")]
		public Animator Animator
		{
			[Token(Token = "0x60014B4")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014B5")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000452")]
		public IkTargetsController IkTargetsController
		{
			[Token(Token = "0x60014B6")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014B7")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000453")]
		public CoopPlayerRemoteSetup RemoteSetup
		{
			[Token(Token = "0x60014B8")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014B9")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000454")]
		public Transform LeftHandWeapon
		{
			[Token(Token = "0x60014BA")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014BB")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000455")]
		public Transform RightHandWeapon
		{
			[Token(Token = "0x60014BC")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014BD")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000456")]
		public ItemInstance RightHandItem
		{
			[Token(Token = "0x60014BE")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014BF")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0000C044 File Offset: 0x0000A244
		[Token(Token = "0x17000457")]
		public AnimatorStateInfo UpperBodyState
		{
			[Token(Token = "0x60014C0")]
			[Address(RVA = "0x2DF6340", Offset = "0x2DF4940", VA = "0x182DF6340", Slot = "8")]
			get
			{
				return default(AnimatorStateInfo);
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0000C05C File Offset: 0x0000A25C
		[Token(Token = "0x17000458")]
		public AnimatorStateInfo NextUpperBodyState
		{
			[Token(Token = "0x60014C1")]
			[Address(RVA = "0x2DF63F0", Offset = "0x2DF49F0", VA = "0x182DF63F0", Slot = "9")]
			get
			{
				return default(AnimatorStateInfo);
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x2DF64A0", Offset = "0x2DF4AA0", VA = "0x182DF64A0")]
		private void Awake()
		{
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x2DF65D0", Offset = "0x2DF4BD0", VA = "0x182DF65D0")]
		public void OnItemEquipped(ItemInstance instance)
		{
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		public void InitiatePlaceAnim()
		{
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		public void ClearPlaceAnim()
		{
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x2DF6660", Offset = "0x2DF4C60", VA = "0x182DF6660", Slot = "14")]
		public IkHeldRenderer GetRightHandIkRenderer()
		{
			return null;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		public void SetStateAnimControlledCamera(State state)
		{
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		public void SetStateMovementLockedAndGrounded(State state)
		{
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		public void SetStateBlockedInput(State state)
		{
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "18")]
		public void SetStateAnimationControllingWeaponClipBlend(State state)
		{
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "19")]
		public void SetStateBuildMode(State state)
		{
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		public void EnableAnimatedMode()
		{
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0000C074 File Offset: 0x0000A274
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x2DF66E0", Offset = "0x2DF4CE0", VA = "0x182DF66E0", Slot = "21")]
		public bool IsLookingDown()
		{
			return default(bool);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0000C08C File Offset: 0x0000A28C
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x2DF6710", Offset = "0x2DF4D10", VA = "0x182DF6710", Slot = "22")]
		public bool IsBelowWaist(float worldHeight)
		{
			return default(bool);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "23")]
		public void StashLeftHandItem(bool memorizeItem)
		{
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "24")]
		public void EquipPreviousLeftHandItem()
		{
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "41")]
		public void AimAxeAtBuildingBlock(Vector3 targetPosition)
		{
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "42")]
		public void OnTogglePlacementMode()
		{
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x2DF67A0", Offset = "0x2DF4DA0", VA = "0x182DF67A0", Slot = "25")]
		public void BeginHorizontalCutPromptIk(TargetInfo target)
		{
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x2DF6F50", Offset = "0x2DF5550", VA = "0x182DF6F50", Slot = "26")]
		public void BeginVerticalCutPromptIk(TargetInfo target, bool allowAimingAbove)
		{
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x2DF7A40", Offset = "0x2DF6040", VA = "0x182DF7A40", Slot = "27")]
		public void BeginHeldItemPromptIk(Vector3 rightHandIkPos, Quaternion rotation, float ikWeight = 1f, bool bothHands = true)
		{
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x2DF7AB0", Offset = "0x2DF60B0", VA = "0x182DF7AB0", Slot = "28")]
		public void BeginHeldItemIk(float smoothDuration, Vector3 rightHandIkPos, Quaternion rotation, float ikWeight = 1f, bool bothHands = true, float delay = 0f)
		{
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x2DF7B30", Offset = "0x2DF6130", VA = "0x182DF7B30", Slot = "29")]
		public void StopHeldItemIk()
		{
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x2DF7B60", Offset = "0x2DF6160", VA = "0x182DF7B60", Slot = "30")]
		public void BeginHeldRendererOnlyIK(Vector3 pos, Quaternion rot, Vector3 scale, IkSides sides, IkFilters filter = IkFilters.PosRotScale)
		{
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x2DF7BF0", Offset = "0x2DF61F0", VA = "0x182DF7BF0", Slot = "31")]
		public void BeginHeldRendererOnlyIK(Vector3 pos, Quaternion rot, Vector3 scale, IkSides sides, float delay, float smoothDuration, IkFilters filter = IkFilters.PosRotScale)
		{
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x2DF7CB0", Offset = "0x2DF62B0", VA = "0x182DF7CB0", Slot = "32")]
		public void StopHeldRendererOnlyIK(IkSides sides, bool smooth = false)
		{
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x2DF7CD0", Offset = "0x2DF62D0", VA = "0x182DF7CD0", Slot = "33")]
		public void BeginHandIk(float smoothDuration, Vector3 handIkPos, Quaternion rotation, bool rightHand, bool maintainRotation, float ikWeight = 1f, float delay = 0f)
		{
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x2DF7D80", Offset = "0x2DF6380", VA = "0x182DF7D80", Slot = "34")]
		public void StopHandsIk(bool rightHand = true, bool leftHand = true)
		{
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x2DF7DC0", Offset = "0x2DF63C0", VA = "0x182DF7DC0", Slot = "35")]
		public void BeginAimIk(Vector3 worldPos, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x2DF7E20", Offset = "0x2DF6420", VA = "0x182DF7E20", Slot = "36")]
		public void BeginAimIk(float smoothDuration, Vector3 worldPos, IkAimModes aimModes = IkAimModes.Position, float delay = 0f)
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x2DF7E80", Offset = "0x2DF6480", VA = "0x182DF7E80", Slot = "37")]
		public void BeginPlaceAimIk(TargetInfo target, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x2DF7E80", Offset = "0x2DF6480", VA = "0x182DF7E80", Slot = "38")]
		public void BeginCutAimIk(TargetInfo target, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x2DF7EE0", Offset = "0x2DF64E0", VA = "0x182DF7EE0", Slot = "39")]
		public void StopAimIk()
		{
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x2DF7F00", Offset = "0x2DF6500", VA = "0x182DF7F00", Slot = "40")]
		public void SpawnHeldRendererPlaceHolder(IkSides rightHand, [Optional] Transform rendererTr)
		{
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x2DF8200", Offset = "0x2DF6800", VA = "0x182DF8200")]
		private static Vector3 GetSizeFromTarget(TargetInfo target)
		{
			return default(Vector3);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ConstructionAnimationRemoteActor()
		{
		}

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StructureElementPlaceHolder _heldRendererPlaceHolderContainerPrefab;
	}
}
