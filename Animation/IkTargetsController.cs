using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation
{
	// Token: 0x02000895 RID: 2197
	[Token(Token = "0x2000895")]
	[AddComponentMenu("Sons/Construction/IkTargetsController")]
	public class IkTargetsController : MonoBehaviour
	{
		// Token: 0x06003B42 RID: 15170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B42")]
		[Address(RVA = "0x2EFD080", Offset = "0x2EFC080", VA = "0x182EFD080")]
		protected void Awake()
		{
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B43")]
		[Address(RVA = "0x2EFED90", Offset = "0x2EFDD90", VA = "0x182EFED90")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x2EFEC30", Offset = "0x2EFDC30", VA = "0x182EFEC30")]
		public void ForceUpdate()
		{
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B45")]
		[Address(RVA = "0x2EFE850", Offset = "0x2EFD850", VA = "0x182EFE850")]
		private void BeginTestAimIK()
		{
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B46")]
		[Address(RVA = "0x2EFF360", Offset = "0x2EFE360", VA = "0x182EFF360")]
		private void StopTestAimIK()
		{
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B47")]
		[Address(RVA = "0x2EFE770", Offset = "0x2EFD770", VA = "0x182EFE770")]
		private void BeginRightHandIK()
		{
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B48")]
		[Address(RVA = "0x2EFE670", Offset = "0x2EFD670", VA = "0x182EFE670")]
		private void BeginLeftHandIK(Transform relTo)
		{
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B49")]
		[Address(RVA = "0x2EFF830", Offset = "0x2EFE830", VA = "0x182EFF830")]
		private void StopRightHandIK()
		{
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4A")]
		[Address(RVA = "0x2EFF800", Offset = "0x2EFE800", VA = "0x182EFF800")]
		private void StopLeftHandIK()
		{
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4B")]
		[Address(RVA = "0x2EFEB20", Offset = "0x2EFDB20", VA = "0x182EFEB20")]
		private void BeginWeaponIK()
		{
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4C")]
		[Address(RVA = "0x2EFEA60", Offset = "0x2EFDA60", VA = "0x182EFEA60")]
		private void BeginWeaponIKBothHands()
		{
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4D")]
		[Address(RVA = "0x2EFF480", Offset = "0x2EFE480", VA = "0x182EFF480")]
		private void StopWeaponIK()
		{
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4E")]
		[Address(RVA = "0x2EFDBC0", Offset = "0x2EFCBC0", VA = "0x182EFDBC0")]
		private void BeginHeldRendererOnlyIKBothHands()
		{
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x2EFF660", Offset = "0x2EFE660", VA = "0x182EFF660")]
		private void StopHeldRendererIK()
		{
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x2EFF060", Offset = "0x2EFE060", VA = "0x182EFF060")]
		public void Register(IIkHeldRenderer heldRenderer)
		{
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x2EFFB70", Offset = "0x2EFEB70", VA = "0x182EFFB70")]
		public void Unregister(IIkHeldRenderer heldRenderer)
		{
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x2EFF120", Offset = "0x2EFE120", VA = "0x182EFF120")]
		public void Register(IIkFakeBone fakeBone)
		{
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x2EFFC50", Offset = "0x2EFEC50", VA = "0x182EFFC50")]
		public void Unregister(IIkFakeBone fakeBone)
		{
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B54")]
		[Address(RVA = "0x2EFF1F0", Offset = "0x2EFE1F0", VA = "0x182EFF1F0")]
		public void Register(IPostIKUpdater postIKUpdater)
		{
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x2EFFB10", Offset = "0x2EFEB10", VA = "0x182EFFB10")]
		public void Unregister(IPostIKUpdater postIKUpdater)
		{
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B56")]
		[Address(RVA = "0x2EFD400", Offset = "0x2EFC400", VA = "0x182EFD400")]
		public void BeginAimIK(Vector3 pos, float posWeight = 1f, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B57")]
		[Address(RVA = "0x2EFD220", Offset = "0x2EFC220", VA = "0x182EFD220")]
		public void BeginAimIK(float delay, float duration, Vector3 pos, float posWeight = 1f, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B58")]
		[Address(RVA = "0x2EFF360", Offset = "0x2EFE360", VA = "0x182EFF360")]
		public void StopAimIK()
		{
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B59")]
		[Address(RVA = "0x2EFD820", Offset = "0x2EFC820", VA = "0x182EFD820")]
		public void BeginHandsIK(Vector3 pos, Quaternion rot, bool rightHand, float posWeight = 1f)
		{
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5A")]
		[Address(RVA = "0x2EFD5E0", Offset = "0x2EFC5E0", VA = "0x182EFD5E0")]
		public void BeginHandIK(float delay, float smoothDuration, Vector3 pos, Quaternion rot, bool rightHand, bool maintainRotation, float posWeight = 1f, [Optional] Transform relativeTo)
		{
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5B")]
		[Address(RVA = "0x2EFE510", Offset = "0x2EFD510", VA = "0x182EFE510")]
		public void BeginLeftHandFlashlightIK(float smoothDuration, float posWeight, Transform relativeTo, Vector3 pos, Transform relativeTo2, Vector3 relativePos2, Quaternion rot)
		{
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5C")]
		[Address(RVA = "0x2EFF2D0", Offset = "0x2EFE2D0", VA = "0x182EFF2D0")]
		public void SetLeftElbowTarget(Transform elbowDirectionTr)
		{
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5D")]
		[Address(RVA = "0x2EFF450", Offset = "0x2EFE450", VA = "0x182EFF450")]
		public void StopHandIK(bool stopRight = true, bool stopLeft = true)
		{
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5E")]
		[Address(RVA = "0x2EFF860", Offset = "0x2EFE860", VA = "0x182EFF860")]
		public void StopTwoHandsIK(float smoothDuration, bool stopRight = true, bool stopLeft = true)
		{
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5F")]
		[Address(RVA = "0x2EFDA20", Offset = "0x2EFCA20", VA = "0x182EFDA20")]
		public void BeginHeldItemIK(Vector3 pos, Quaternion rot, float posWeight = 1f, bool bothHands = true)
		{
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B60")]
		[Address(RVA = "0x2EFD890", Offset = "0x2EFC890", VA = "0x182EFD890")]
		public void BeginHeldItemIK(float delay, float smoothDuration, Vector3 pos, Quaternion rot, float posWeight = 1f, bool bothHands = true)
		{
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x2EFF480", Offset = "0x2EFE480", VA = "0x182EFF480")]
		public void StopHeldItemIK()
		{
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B62")]
		[Address(RVA = "0x2EFF570", Offset = "0x2EFE570", VA = "0x182EFF570")]
		public void StopHeldItemIK(float smoothDuration)
		{
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B63")]
		[Address(RVA = "0x2EFE0B0", Offset = "0x2EFD0B0", VA = "0x182EFE0B0")]
		public void BeginHeldRendererOnlyIK(IkFilters filter, Vector3 pos, Quaternion rot, Vector3 worldScale, IkSides sides, float delay = 0f)
		{
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B64")]
		[Address(RVA = "0x2EFDF20", Offset = "0x2EFCF20", VA = "0x182EFDF20")]
		public void BeginHeldRendererOnlyIK(IkFilters filter, Vector3 pos, Quaternion rot, Vector3 worldScale, IkSides sides, float delay, float smoothDuration)
		{
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B65")]
		[Address(RVA = "0x2EFE390", Offset = "0x2EFD390", VA = "0x182EFE390")]
		private void BeginHeldRendererOnlyIK(IkTargetsController.IkOperationHeldRenderer operation, float delay, float smoothDuration, Vector3 pos, Quaternion rot, Vector3 worldScale, IkFilters filter)
		{
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B66")]
		[Address(RVA = "0x2EFF780", Offset = "0x2EFE780", VA = "0x182EFF780")]
		public void StopHeldRendererOnlyIK(IkSides sides, bool smooth = false)
		{
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B67")]
		[Address(RVA = "0x2EFF690", Offset = "0x2EFE690", VA = "0x182EFF690")]
		private void StopHeldRendererOnlyIK(IkTargetsController.IkOperationHeldRenderer operation, float smoothDuration)
		{
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B68")]
		[Address(RVA = "0x2EFED60", Offset = "0x2EFDD60", VA = "0x182EFED60")]
		public IIkHeldRenderer GetHeldRenderer(IkLimbs limb)
		{
			return null;
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B69")]
		[Address(RVA = "0x2EFEBE0", Offset = "0x2EFDBE0", VA = "0x182EFEBE0")]
		private void CheckRunningOperation()
		{
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6A")]
		[Address(RVA = "0x2EFCF40", Offset = "0x2EFBF40", VA = "0x182EFCF40")]
		private void AddRunningOperation(IkTargetsController.IkOperation op)
		{
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x00011430 File Offset: 0x0000F630
		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x2EFFA40", Offset = "0x2EFEA40", VA = "0x182EFFA40")]
		public static bool TryFindFor(GameObject go, ref IkTargetsController controller)
		{
			return default(bool);
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6C")]
		[Address(RVA = "0x2EFFD40", Offset = "0x2EFED40", VA = "0x182EFFD40")]
		public IkTargetsController()
		{
		}

		// Token: 0x04003FA2 RID: 16290
		[Token(Token = "0x4003FA2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("FinalIK")]
		private LimbIK _leftHandLimb;

		// Token: 0x04003FA3 RID: 16291
		[Token(Token = "0x4003FA3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LimbIK _rightHandLimb;

		// Token: 0x04003FA4 RID: 16292
		[Token(Token = "0x4003FA4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BipedIK _bipped;

		// Token: 0x04003FA5 RID: 16293
		[Token(Token = "0x4003FA5")]
		[FieldOffset(Offset = "0x38")]
		[Header("Operations")]
		[SerializeField]
		private IkTargetsController.IkOperationAim _aimIKOperation;

		// Token: 0x04003FA6 RID: 16294
		[Token(Token = "0x4003FA6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private IkTargetsController.IkOperationWeapon _weaponIKOperation;

		// Token: 0x04003FA7 RID: 16295
		[Token(Token = "0x4003FA7")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_weaponBoneOnlyIKOperation")]
		[SerializeField]
		private IkTargetsController.IkOperationHeldRenderer _leftHeldRendererOnlyIKOperation;

		// Token: 0x04003FA8 RID: 16296
		[Token(Token = "0x4003FA8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("_weaponBoneOnlyIKOperation")]
		private IkTargetsController.IkOperationHeldRenderer _rightHeldRendererOnlyIKOperation;

		// Token: 0x04003FA9 RID: 16297
		[Token(Token = "0x4003FA9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private IkTargetsController.IkOperationOffFakeBone _rightHandIKOperation;

		// Token: 0x04003FAA RID: 16298
		[Token(Token = "0x4003FAA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private IkTargetsController.IkOperationOffFakeBone _leftHandIKOperation;

		// Token: 0x04003FAB RID: 16299
		[Token(Token = "0x4003FAB")]
		[FieldOffset(Offset = "0x68")]
		[Header("Settings")]
		[SerializeField]
		private float _smoothDuration;

		// Token: 0x04003FAC RID: 16300
		[Token(Token = "0x4003FAC")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _stopIkSmoothDuration;

		// Token: 0x04003FAD RID: 16301
		[Token(Token = "0x4003FAD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _defaultLeftElbowTarget;

		// Token: 0x04003FAE RID: 16302
		[Token(Token = "0x4003FAE")]
		[FieldOffset(Offset = "0x78")]
		private List<IkTargetsController.IkOperation> _activeOperations;

		// Token: 0x04003FAF RID: 16303
		[Token(Token = "0x4003FAF")]
		[FieldOffset(Offset = "0x80")]
		private List<IPostIKUpdater> _postIKUpdaters;

		// Token: 0x02000896 RID: 2198
		[Token(Token = "0x2000896")]
		[Serializable]
		public abstract class IkOperation
		{
			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x06003B6D RID: 15213 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700073E")]
			public Transform IkTarget
			{
				[Token(Token = "0x6003B6D")]
				[Address(RVA = "0x68B100", Offset = "0x68A100", VA = "0x18068B100")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003B6E RID: 15214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B6E")]
			[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
			public virtual void Init()
			{
			}

			// Token: 0x06003B6F RID: 15215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B6F")]
			[Address(RVA = "0x2EFC7A0", Offset = "0x2EFB7A0", VA = "0x182EFC7A0")]
			public void BeginSmoothWeightUpdate(float delay, float posWeight, IKSolver solver)
			{
			}

			// Token: 0x06003B70 RID: 15216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B70")]
			[Address(RVA = "0x2EFCE20", Offset = "0x2EFBE20", VA = "0x182EFCE20")]
			public void SmoothWeightUpdate()
			{
			}

			// Token: 0x06003B71 RID: 15217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B71")]
			[Address(RVA = "0x2EFC920", Offset = "0x2EFB920", VA = "0x182EFC920")]
			public void RelativePosRotUpdate()
			{
			}

			// Token: 0x06003B72 RID: 15218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B72")]
			[Address(RVA = "0x2EFC710", Offset = "0x2EFB710", VA = "0x182EFC710", Slot = "5")]
			protected virtual void ApplyWeight(float weight)
			{
			}

			// Token: 0x06003B73 RID: 15219
			[Token(Token = "0x6003B73")]
			public abstract void UpdateIK();

			// Token: 0x06003B74 RID: 15220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B74")]
			[Address(RVA = "0x2EFCDC0", Offset = "0x2EFBDC0", VA = "0x182EFCDC0")]
			public void Shutdown()
			{
			}

			// Token: 0x06003B75 RID: 15221 RVA: 0x00011448 File Offset: 0x0000F648
			[Token(Token = "0x6003B75")]
			[Address(RVA = "0x2EFC900", Offset = "0x2EFB900", VA = "0x182EFC900")]
			protected float GetSmoothDuration()
			{
				return default(float);
			}

			// Token: 0x06003B76 RID: 15222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B76")]
			[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "7")]
			protected virtual void OnBegin()
			{
			}

			// Token: 0x06003B77 RID: 15223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B77")]
			[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "8")]
			protected virtual void OnPostShutdown()
			{
			}

			// Token: 0x06003B78 RID: 15224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B78")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			protected IkOperation()
			{
			}

			// Token: 0x04003FB0 RID: 16304
			[Token(Token = "0x4003FB0")]
			[FieldOffset(Offset = "0x10")]
			[Header("Runtime State")]
			public bool _running;

			// Token: 0x04003FB1 RID: 16305
			[Token(Token = "0x4003FB1")]
			[FieldOffset(Offset = "0x18")]
			public IKSolver _solver;

			// Token: 0x04003FB2 RID: 16306
			[Token(Token = "0x4003FB2")]
			[FieldOffset(Offset = "0x20")]
			public IIkFakeBone _fakeBone;

			// Token: 0x04003FB3 RID: 16307
			[Token(Token = "0x4003FB3")]
			[FieldOffset(Offset = "0x28")]
			public float _activationTime;

			// Token: 0x04003FB4 RID: 16308
			[Token(Token = "0x4003FB4")]
			[FieldOffset(Offset = "0x2C")]
			public float _activeIkSmoothDuration;

			// Token: 0x04003FB5 RID: 16309
			[Token(Token = "0x4003FB5")]
			[FieldOffset(Offset = "0x30")]
			public float _stopIkSmoothDuration;

			// Token: 0x04003FB6 RID: 16310
			[Token(Token = "0x4003FB6")]
			[FieldOffset(Offset = "0x34")]
			public float _startPosWeight;

			// Token: 0x04003FB7 RID: 16311
			[Token(Token = "0x4003FB7")]
			[FieldOffset(Offset = "0x38")]
			public float _targetPosWeight;

			// Token: 0x04003FB8 RID: 16312
			[Token(Token = "0x4003FB8")]
			[FieldOffset(Offset = "0x3C")]
			public float _currentWeight;

			// Token: 0x04003FB9 RID: 16313
			[Token(Token = "0x4003FB9")]
			[FieldOffset(Offset = "0x40")]
			public Transform _relativeTo;

			// Token: 0x04003FBA RID: 16314
			[Token(Token = "0x4003FBA")]
			[FieldOffset(Offset = "0x48")]
			public Vector3 _relPos;

			// Token: 0x04003FBB RID: 16315
			[Token(Token = "0x4003FBB")]
			[FieldOffset(Offset = "0x54")]
			public Quaternion _relRot;

			// Token: 0x04003FBC RID: 16316
			[Token(Token = "0x4003FBC")]
			[FieldOffset(Offset = "0x68")]
			public Transform _relativeTo2;

			// Token: 0x04003FBD RID: 16317
			[Token(Token = "0x4003FBD")]
			[FieldOffset(Offset = "0x70")]
			public Vector3 _relativePos2;

			// Token: 0x04003FBE RID: 16318
			[Token(Token = "0x4003FBE")]
			[FieldOffset(Offset = "0x80")]
			[Header("References")]
			[SerializeField]
			protected Transform _ikTarget;
		}

		// Token: 0x02000897 RID: 2199
		[Token(Token = "0x2000897")]
		[Serializable]
		public class IkOperationOffFakeBone : IkTargetsController.IkOperation
		{
			// Token: 0x06003B79 RID: 15225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B79")]
			[Address(RVA = "0x2EFB700", Offset = "0x2EFA700", VA = "0x182EFB700", Slot = "6")]
			public override void UpdateIK()
			{
			}

			// Token: 0x06003B7A RID: 15226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B7A")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public IkOperationOffFakeBone()
			{
			}

			// Token: 0x04003FBF RID: 16319
			[Token(Token = "0x4003FBF")]
			[FieldOffset(Offset = "0x88")]
			private Vector3 _handRelativePos;

			// Token: 0x04003FC0 RID: 16320
			[Token(Token = "0x4003FC0")]
			[FieldOffset(Offset = "0x94")]
			private Quaternion _handRelativeRot;
		}

		// Token: 0x02000898 RID: 2200
		[Token(Token = "0x2000898")]
		[Serializable]
		public class IkOperationAim : IkTargetsController.IkOperation
		{
			// Token: 0x06003B7B RID: 15227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B7B")]
			[Address(RVA = "0x2EFAEB0", Offset = "0x2EF9EB0", VA = "0x182EFAEB0", Slot = "6")]
			public override void UpdateIK()
			{
			}

			// Token: 0x06003B7C RID: 15228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B7C")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public IkOperationAim()
			{
			}

			// Token: 0x04003FC1 RID: 16321
			[Token(Token = "0x4003FC1")]
			[FieldOffset(Offset = "0x88")]
			public Transform _mainTransform;

			// Token: 0x04003FC2 RID: 16322
			[Token(Token = "0x4003FC2")]
			[FieldOffset(Offset = "0x90")]
			public Vector3 _aimIkStartOffset;

			// Token: 0x04003FC3 RID: 16323
			[Token(Token = "0x4003FC3")]
			[FieldOffset(Offset = "0x9C")]
			public IkAimModes _aimModes;
		}

		// Token: 0x02000899 RID: 2201
		[Token(Token = "0x2000899")]
		[Serializable]
		public class IkOperationWeapon : IkTargetsController.IkOperation
		{
			// Token: 0x06003B7D RID: 15229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B7D")]
			[Address(RVA = "0x2EFBCD0", Offset = "0x2EFACD0", VA = "0x182EFBCD0", Slot = "5")]
			protected override void ApplyWeight(float weight)
			{
			}

			// Token: 0x06003B7E RID: 15230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B7E")]
			[Address(RVA = "0x2EFBE20", Offset = "0x2EFAE20", VA = "0x182EFBE20", Slot = "6")]
			public override void UpdateIK()
			{
			}

			// Token: 0x06003B7F RID: 15231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B7F")]
			[Address(RVA = "0x2EFBDE0", Offset = "0x2EFADE0", VA = "0x182EFBDE0", Slot = "8")]
			protected override void OnPostShutdown()
			{
			}

			// Token: 0x06003B80 RID: 15232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B80")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public IkOperationWeapon()
			{
			}

			// Token: 0x04003FC4 RID: 16324
			[Token(Token = "0x4003FC4")]
			[FieldOffset(Offset = "0x88")]
			[SerializeField]
			private Transform _leftHandBone;

			// Token: 0x04003FC5 RID: 16325
			[Token(Token = "0x4003FC5")]
			[FieldOffset(Offset = "0x90")]
			public IKSolver _leftHandSolver;

			// Token: 0x04003FC6 RID: 16326
			[Token(Token = "0x4003FC6")]
			[FieldOffset(Offset = "0x98")]
			public IKSolver _aimSolver;

			// Token: 0x04003FC7 RID: 16327
			[Token(Token = "0x4003FC7")]
			[FieldOffset(Offset = "0xA0")]
			private Vector3 _leftHandPosRelToRight;

			// Token: 0x04003FC8 RID: 16328
			[Token(Token = "0x4003FC8")]
			[FieldOffset(Offset = "0xAC")]
			private Quaternion _leftHandRotRelToRight;

			// Token: 0x04003FC9 RID: 16329
			[Token(Token = "0x4003FC9")]
			[FieldOffset(Offset = "0xBC")]
			private Vector3 _rightHandRelativePos;

			// Token: 0x04003FCA RID: 16330
			[Token(Token = "0x4003FCA")]
			[FieldOffset(Offset = "0xC8")]
			private Quaternion _rightHandRelativeRot;
		}

		// Token: 0x0200089A RID: 2202
		[Token(Token = "0x200089A")]
		[Serializable]
		public class IkOperationHeldRenderer : IkTargetsController.IkOperation
		{
			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06003B81 RID: 15233 RVA: 0x00011460 File Offset: 0x0000F660
			// (set) Token: 0x06003B82 RID: 15234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700073F")]
			public IkFilters Filter
			{
				[Token(Token = "0x6003B81")]
				[Address(RVA = "0x5CEF50", Offset = "0x5CDF50", VA = "0x1805CEF50")]
				[CompilerGenerated]
				get
				{
					return (IkFilters)0;
				}
				[Token(Token = "0x6003B82")]
				[Address(RVA = "0x5CEF70", Offset = "0x5CDF70", VA = "0x1805CEF70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06003B83 RID: 15235 RVA: 0x00011478 File Offset: 0x0000F678
			[Token(Token = "0x17000740")]
			public bool ApplyPosition
			{
				[Token(Token = "0x6003B83")]
				[Address(RVA = "0x2EFB6D0", Offset = "0x2EFA6D0", VA = "0x182EFB6D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06003B84 RID: 15236 RVA: 0x00011490 File Offset: 0x0000F690
			[Token(Token = "0x17000741")]
			public bool ApplyRotation
			{
				[Token(Token = "0x6003B84")]
				[Address(RVA = "0x2EFB6E0", Offset = "0x2EFA6E0", VA = "0x182EFB6E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x06003B85 RID: 15237 RVA: 0x000114A8 File Offset: 0x0000F6A8
			[Token(Token = "0x17000742")]
			public bool ApplyScale
			{
				[Token(Token = "0x6003B85")]
				[Address(RVA = "0x2EFB6F0", Offset = "0x2EFA6F0", VA = "0x182EFB6F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x06003B86 RID: 15238 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003B87 RID: 15239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000743")]
			public IIkHeldRenderer HeldRenderer
			{
				[Token(Token = "0x6003B86")]
				[Address(RVA = "0x582960", Offset = "0x581960", VA = "0x180582960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003B87")]
				[Address(RVA = "0x7B2350", Offset = "0x7B1350", VA = "0x1807B2350")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06003B88 RID: 15240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B88")]
			[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
			public override void Init()
			{
			}

			// Token: 0x06003B89 RID: 15241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B89")]
			[Address(RVA = "0x2EFAF70", Offset = "0x2EF9F70", VA = "0x182EFAF70", Slot = "5")]
			protected override void ApplyWeight(float weight)
			{
			}

			// Token: 0x06003B8A RID: 15242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B8A")]
			[Address(RVA = "0x2EFB010", Offset = "0x2EFA010", VA = "0x182EFB010", Slot = "6")]
			public override void UpdateIK()
			{
			}

			// Token: 0x06003B8B RID: 15243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B8B")]
			[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "7")]
			protected override void OnBegin()
			{
			}

			// Token: 0x06003B8C RID: 15244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B8C")]
			[Address(RVA = "0x2EFAFF0", Offset = "0x2EF9FF0", VA = "0x182EFAFF0", Slot = "8")]
			protected override void OnPostShutdown()
			{
			}

			// Token: 0x06003B8D RID: 15245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B8D")]
			[Address(RVA = "0x2EFAFB0", Offset = "0x2EF9FB0", VA = "0x182EFAFB0")]
			public void ClearHeldRenderer()
			{
			}

			// Token: 0x06003B8E RID: 15246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B8E")]
			[Address(RVA = "0x2EFB6B0", Offset = "0x2EFA6B0", VA = "0x182EFB6B0")]
			public IkOperationHeldRenderer()
			{
			}

			// Token: 0x04003FCB RID: 16331
			[Token(Token = "0x4003FCB")]
			[FieldOffset(Offset = "0x88")]
			private float _weight;
		}
	}
}
