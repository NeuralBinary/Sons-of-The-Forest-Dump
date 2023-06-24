using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	[AddComponentMenu("Sons/Construction/Anim/ConstructionAnimationActor")]
	public class ConstructionAnimationActor : MonoBehaviour, IConstructionAnimationActor, IHitReactReceiver
	{
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000447")]
		public Transform MainTr
		{
			[Token(Token = "0x6001485")]
			[Address(RVA = "0x2D80530", Offset = "0x2D7EB30", VA = "0x182D80530", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000448")]
		public Transform LookTr
		{
			[Token(Token = "0x6001486")]
			[Address(RVA = "0x2D806F0", Offset = "0x2D7ECF0", VA = "0x182D806F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000449")]
		public ItemInstance RightHandItem
		{
			[Token(Token = "0x6001487")]
			[Address(RVA = "0x2DF2AF0", Offset = "0x2DF10F0", VA = "0x182DF2AF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700044A")]
		public Animator Animator
		{
			[Token(Token = "0x6001488")]
			[Address(RVA = "0x2DF2B50", Offset = "0x2DF1150", VA = "0x182DF2B50", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		[Token(Token = "0x1700044B")]
		public AnimatorStateInfo UpperBodyState
		{
			[Token(Token = "0x6001489")]
			[Address(RVA = "0x2DF2B90", Offset = "0x2DF1190", VA = "0x182DF2B90", Slot = "8")]
			get
			{
				return default(AnimatorStateInfo);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		[Token(Token = "0x1700044C")]
		public AnimatorStateInfo NextUpperBodyState
		{
			[Token(Token = "0x600148A")]
			[Address(RVA = "0x2DF2C00", Offset = "0x2DF1200", VA = "0x182DF2C00", Slot = "9")]
			get
			{
				return default(AnimatorStateInfo);
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700044D")]
		public Transform LeftHandWeapon
		{
			[Token(Token = "0x600148B")]
			[Address(RVA = "0x2DF2C70", Offset = "0x2DF1270", VA = "0x182DF2C70", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700044E")]
		public Transform RightHandWeapon
		{
			[Token(Token = "0x600148C")]
			[Address(RVA = "0x2DF2CC0", Offset = "0x2DF12C0", VA = "0x182DF2CC0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x2DF2D10", Offset = "0x2DF1310", VA = "0x182DF2D10")]
		private void Awake()
		{
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x2DF2F80", Offset = "0x2DF1580", VA = "0x182DF2F80", Slot = "12")]
		public void InitiatePlaceAnim()
		{
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x2DF3060", Offset = "0x2DF1660", VA = "0x182DF3060", Slot = "13")]
		public void ClearPlaceAnim()
		{
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x2DF3140", Offset = "0x2DF1740", VA = "0x182DF3140", Slot = "14")]
		public IkHeldRenderer GetRightHandIkRenderer()
		{
			return null;
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x2DF3210", Offset = "0x2DF1810", VA = "0x182DF3210", Slot = "15")]
		public void SetStateAnimControlledCamera(State state)
		{
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x2DF32B0", Offset = "0x2DF18B0", VA = "0x182DF32B0", Slot = "16")]
		public void SetStateMovementLockedAndGrounded(State state)
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x2DF3360", Offset = "0x2DF1960", VA = "0x182DF3360", Slot = "17")]
		public void SetStateBlockedInput(State state)
		{
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x2DF3490", Offset = "0x2DF1A90", VA = "0x182DF3490", Slot = "18")]
		public void SetStateAnimationControllingWeaponClipBlend(State state)
		{
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x2DF34F0", Offset = "0x2DF1AF0", VA = "0x182DF34F0", Slot = "41")]
		public void AimAxeAtBuildingBlock(Vector3 targetPosition)
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x2DF37A0", Offset = "0x2DF1DA0", VA = "0x182DF37A0", Slot = "42")]
		public void OnTogglePlacementMode()
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x2DF39F0", Offset = "0x2DF1FF0", VA = "0x182DF39F0", Slot = "19")]
		public void SetStateBuildMode(State state)
		{
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x2DF3EF0", Offset = "0x2DF24F0", VA = "0x182DF3EF0", Slot = "20")]
		public void EnableAnimatedMode()
		{
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0000BFFC File Offset: 0x0000A1FC
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x2DF4010", Offset = "0x2DF2610", VA = "0x182DF4010", Slot = "21")]
		public bool IsLookingDown()
		{
			return default(bool);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0000C014 File Offset: 0x0000A214
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x2DF4070", Offset = "0x2DF2670", VA = "0x182DF4070", Slot = "22")]
		public bool IsBelowWaist(float worldHeight)
		{
			return default(bool);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x2DF4130", Offset = "0x2DF2730", VA = "0x182DF4130", Slot = "23")]
		public void StashLeftHandItem(bool memorizeItem)
		{
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x2DF4190", Offset = "0x2DF2790", VA = "0x182DF4190", Slot = "24")]
		public void EquipPreviousLeftHandItem()
		{
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "40")]
		public void SpawnHeldRendererPlaceHolder(IkSides rightHand, [Optional] Transform rendererTr)
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x2DF44E0", Offset = "0x2DF2AE0", VA = "0x182DF44E0", Slot = "43")]
		private void HitReact()
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x2DF4510", Offset = "0x2DF2B10", VA = "0x182DF4510", Slot = "25")]
		public void BeginHorizontalCutPromptIk(TargetInfo target)
		{
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x2DF4D30", Offset = "0x2DF3330", VA = "0x182DF4D30", Slot = "26")]
		public void BeginVerticalCutPromptIk(TargetInfo target, bool allowAimingAbove)
		{
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x2DF58A0", Offset = "0x2DF3EA0", VA = "0x182DF58A0", Slot = "27")]
		public void BeginHeldItemPromptIk(Vector3 rightHandIkPos, Quaternion rotation, float ikWeight = 1f, bool bothHands = true)
		{
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x2DF5960", Offset = "0x2DF3F60", VA = "0x182DF5960", Slot = "28")]
		public void BeginHeldItemIk(float smoothDuration, Vector3 rightHandIkPos, Quaternion rotation, float ikWeight = 1f, bool bothHands = true, float delay = 0f)
		{
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x2DF5A30", Offset = "0x2DF4030", VA = "0x182DF5A30", Slot = "29")]
		public void StopHeldItemIk()
		{
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x2DF5A90", Offset = "0x2DF4090", VA = "0x182DF5A90", Slot = "30")]
		public void BeginHeldRendererOnlyIK(Vector3 pos, Quaternion rot, Vector3 scale, IkSides sides, IkFilters filter = IkFilters.PosRotScale)
		{
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x2DF5B60", Offset = "0x2DF4160", VA = "0x182DF5B60", Slot = "31")]
		public void BeginHeldRendererOnlyIK(Vector3 pos, Quaternion rot, Vector3 scale, IkSides sides, float delay, float smoothDuration, IkFilters filter = IkFilters.PosRotScale)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x2DF5C60", Offset = "0x2DF4260", VA = "0x182DF5C60", Slot = "32")]
		public void StopHeldRendererOnlyIK(IkSides sides, bool smooth = false)
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x2DF5CD0", Offset = "0x2DF42D0", VA = "0x182DF5CD0", Slot = "33")]
		public void BeginHandIk(float smoothDuration, Vector3 handIkPos, Quaternion rotation, bool rightHand, bool maintainRotation, float ikWeight = 1f, float delay = 0f)
		{
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x2DF5DE0", Offset = "0x2DF43E0", VA = "0x182DF5DE0", Slot = "34")]
		public void StopHandsIk(bool rightHand = true, bool leftHand = true)
		{
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x2DF5E60", Offset = "0x2DF4460", VA = "0x182DF5E60", Slot = "35")]
		public void BeginAimIk(Vector3 worldPos, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x2DF5F00", Offset = "0x2DF4500", VA = "0x182DF5F00", Slot = "36")]
		public void BeginAimIk(float smoothDuration, Vector3 worldPos, IkAimModes aimModes = IkAimModes.Position, float delay = 0f)
		{
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x2DF5FB0", Offset = "0x2DF45B0", VA = "0x182DF5FB0", Slot = "37")]
		public void BeginPlaceAimIk(TargetInfo target, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x2DF5FB0", Offset = "0x2DF45B0", VA = "0x182DF5FB0", Slot = "38")]
		public void BeginCutAimIk(TargetInfo target, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x2DF6050", Offset = "0x2DF4650", VA = "0x182DF6050", Slot = "39")]
		public void StopAimIk()
		{
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0000C02C File Offset: 0x0000A22C
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x2DF60A0", Offset = "0x2DF46A0", VA = "0x182DF60A0")]
		private static Vector3 GetSizeFromTarget(TargetInfo target)
		{
			return default(Vector3);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x2DF6260", Offset = "0x2DF4860", VA = "0x182DF6260")]
		public ConstructionAnimationActor()
		{
		}

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ConstructionManager _manager;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _axeAimBlendVal;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _axeAimVelRef;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<int> _buildModeTurnOffAnimatorParameters;
	}
}
