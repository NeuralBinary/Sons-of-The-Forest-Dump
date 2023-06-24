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
	// Token: 0x02000907 RID: 2311
	[Token(Token = "0x2000907")]
	[AddComponentMenu("Sons/Construction/IkTargetsController")]
	public class IkTargetsController : MonoBehaviour
	{
		// Token: 0x0600426E RID: 17006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600426E")]
		[Address(RVA = "0x3635390", Offset = "0x3633990", VA = "0x183635390")]
		private void OnValidate()
		{
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600426F")]
		[Address(RVA = "0x3635510", Offset = "0x3633B10", VA = "0x183635510")]
		protected void Awake()
		{
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004270")]
		[Address(RVA = "0x36358C0", Offset = "0x3633EC0", VA = "0x1836358C0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004271")]
		[Address(RVA = "0x3635AE0", Offset = "0x36340E0", VA = "0x183635AE0")]
		public void ForceUpdate()
		{
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004272")]
		[Address(RVA = "0x3635C40", Offset = "0x3634240", VA = "0x183635C40")]
		private void BeginTestAimIK()
		{
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004273")]
		[Address(RVA = "0x3635D10", Offset = "0x3634310", VA = "0x183635D10")]
		private void StopTestAimIK()
		{
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004274")]
		[Address(RVA = "0x3635D20", Offset = "0x3634320", VA = "0x183635D20")]
		private void BeginRightHandIK()
		{
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004275")]
		[Address(RVA = "0x3635EC0", Offset = "0x36344C0", VA = "0x183635EC0")]
		private void BeginLeftHandIK(Transform relTo)
		{
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004276")]
		[Address(RVA = "0x3636080", Offset = "0x3634680", VA = "0x183636080")]
		private void StopRightHandIK()
		{
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004277")]
		[Address(RVA = "0x36360B0", Offset = "0x36346B0", VA = "0x1836360B0")]
		private void StopLeftHandIK()
		{
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004278")]
		[Address(RVA = "0x36360E0", Offset = "0x36346E0", VA = "0x1836360E0")]
		private void BeginWeaponIK()
		{
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004279")]
		[Address(RVA = "0x3636240", Offset = "0x3634840", VA = "0x183636240")]
		private void BeginWeaponIKBothHands()
		{
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427A")]
		[Address(RVA = "0x36363A0", Offset = "0x36349A0", VA = "0x1836363A0")]
		private void StopWeaponIK()
		{
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427B")]
		[Address(RVA = "0x36363B0", Offset = "0x36349B0", VA = "0x1836363B0")]
		private void BeginHeldRendererOnlyIKBothHands()
		{
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427C")]
		[Address(RVA = "0x36366E0", Offset = "0x3634CE0", VA = "0x1836366E0")]
		private void StopHeldRendererIK()
		{
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427D")]
		[Address(RVA = "0x3636710", Offset = "0x3634D10", VA = "0x183636710")]
		public void Register(IIkHeldRenderer heldRenderer)
		{
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427E")]
		[Address(RVA = "0x3636820", Offset = "0x3634E20", VA = "0x183636820")]
		public void Unregister(IIkHeldRenderer heldRenderer)
		{
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427F")]
		[Address(RVA = "0x36368E0", Offset = "0x3634EE0", VA = "0x1836368E0")]
		public void Register(IIkFakeBone fakeBone)
		{
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004280")]
		[Address(RVA = "0x3636AC0", Offset = "0x36350C0", VA = "0x183636AC0")]
		public void Unregister(IIkFakeBone fakeBone)
		{
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004281")]
		[Address(RVA = "0x3636C60", Offset = "0x3635260", VA = "0x183636C60")]
		public void Register(IPostIKUpdater postIKUpdater)
		{
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004282")]
		[Address(RVA = "0x3636D70", Offset = "0x3635370", VA = "0x183636D70")]
		public void Unregister(IPostIKUpdater postIKUpdater)
		{
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004283")]
		[Address(RVA = "0x3636DD0", Offset = "0x36353D0", VA = "0x183636DD0")]
		public void BeginAimIK(Vector3 pos, float posWeight = 1f, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004284")]
		[Address(RVA = "0x3636E10", Offset = "0x3635410", VA = "0x183636E10")]
		public void BeginAimIK(float delay, float duration, Vector3 pos, float posWeight = 1f, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004285")]
		[Address(RVA = "0x36370F0", Offset = "0x36356F0", VA = "0x1836370F0")]
		public void StopAimIK()
		{
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004286")]
		[Address(RVA = "0x3637290", Offset = "0x3635890", VA = "0x183637290")]
		public void BeginHandsIK(Vector3 pos, Quaternion rot, bool rightHand, float posWeight = 1f)
		{
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004287")]
		[Address(RVA = "0x3637310", Offset = "0x3635910", VA = "0x183637310")]
		public void BeginHandIK(float delay, float smoothDuration, Vector3 pos, Quaternion rot, bool rightHand, bool maintainRotation, float posWeight = 1f, [Optional] Transform relativeTo)
		{
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004288")]
		[Address(RVA = "0x36373B0", Offset = "0x36359B0", VA = "0x1836373B0")]
		public void BeginHandIK(float delay, float smoothDuration, Vector3 pos, Quaternion rot, bool rightHand, bool maintainRotation, out Transform ikTarget, out Transform ikElbowTarget, float posWeight = 1f, [Optional] Transform relativeTo)
		{
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004289")]
		[Address(RVA = "0x36378E0", Offset = "0x3635EE0", VA = "0x1836378E0")]
		public void BeginLeftHandFlashlightIK(float smoothDuration, float posWeight, Transform relativeTo, Vector3 pos, Transform relativeTo2, Vector3 relativePos2, Quaternion rot)
		{
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428A")]
		[Address(RVA = "0x3637B50", Offset = "0x3636150", VA = "0x183637B50")]
		public void SetRightElbowTarget(Transform elbowDirectionTr)
		{
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428B")]
		[Address(RVA = "0x3637C80", Offset = "0x3636280", VA = "0x183637C80")]
		public void SetLeftElbowTarget(Transform elbowDirectionTr)
		{
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428C")]
		[Address(RVA = "0x3637DB0", Offset = "0x36363B0", VA = "0x183637DB0")]
		public void StopHandIK(bool stopRight = true, bool stopLeft = true)
		{
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428D")]
		[Address(RVA = "0x3637DE0", Offset = "0x36363E0", VA = "0x183637DE0")]
		public void StopTwoHandsIK(float smoothDuration, bool stopRight = true, bool stopLeft = true)
		{
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428E")]
		[Address(RVA = "0x36380B0", Offset = "0x36366B0", VA = "0x1836380B0")]
		public void BeginHeldItemIK(Vector3 pos, Quaternion rot, float posWeight = 1f, bool bothHands = true)
		{
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428F")]
		[Address(RVA = "0x3638110", Offset = "0x3636710", VA = "0x183638110")]
		public void BeginHeldItemIK(float delay, float smoothDuration, Vector3 pos, Quaternion rot, float posWeight = 1f, bool bothHands = true)
		{
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004290")]
		[Address(RVA = "0x36363A0", Offset = "0x36349A0", VA = "0x1836363A0")]
		public void StopHeldItemIK()
		{
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004291")]
		[Address(RVA = "0x36383E0", Offset = "0x36369E0", VA = "0x1836383E0")]
		public void StopHeldItemIK(float smoothDuration)
		{
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004292")]
		[Address(RVA = "0x3638580", Offset = "0x3636B80", VA = "0x183638580")]
		public void BeginHeldRendererOnlyIK(IkFilters filter, Vector3 pos, Quaternion rot, Vector3 worldScale, IkSides sides, float delay = 0f)
		{
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004293")]
		[Address(RVA = "0x36386D0", Offset = "0x3636CD0", VA = "0x1836386D0")]
		public void BeginHeldRendererOnlyIK(IkFilters filter, Vector3 pos, Quaternion rot, Vector3 worldScale, IkSides sides, float delay, float smoothDuration)
		{
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004294")]
		[Address(RVA = "0x3638770", Offset = "0x3636D70", VA = "0x183638770")]
		private void BeginHeldRendererOnlyIK(IkTargetsController.IkOperationHeldRenderer operation, float delay, float smoothDuration, Vector3 pos, Quaternion rot, Vector3 worldScale, IkFilters filter)
		{
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004295")]
		[Address(RVA = "0x3638A20", Offset = "0x3637020", VA = "0x183638A20")]
		public void StopHeldRendererOnlyIK(IkSides sides, bool smooth = false)
		{
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004296")]
		[Address(RVA = "0x3638AA0", Offset = "0x36370A0", VA = "0x183638AA0")]
		private void StopHeldRendererOnlyIK(IkTargetsController.IkOperationHeldRenderer operation, float smoothDuration)
		{
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004297")]
		[Address(RVA = "0x3638C10", Offset = "0x3637210", VA = "0x183638C10")]
		public IIkHeldRenderer GetHeldRenderer(IkLimbs limb)
		{
			return null;
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004298")]
		[Address(RVA = "0x3638C40", Offset = "0x3637240", VA = "0x183638C40")]
		private void CheckRunningOperation()
		{
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004299")]
		[Address(RVA = "0x3638CD0", Offset = "0x36372D0", VA = "0x183638CD0")]
		private void AddRunningOperation(IkTargetsController.IkOperation op)
		{
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x000142C8 File Offset: 0x000124C8
		[Token(Token = "0x600429A")]
		[Address(RVA = "0x3638DF0", Offset = "0x36373F0", VA = "0x183638DF0")]
		public static bool TryFindFor(GameObject go, ref IkTargetsController controller)
		{
			return default(bool);
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429B")]
		[Address(RVA = "0x3638F50", Offset = "0x3637550", VA = "0x183638F50")]
		public static void SetupIkChains(List<GameObject> ikTargets, IkTargetsController ikTargetsController, float handleIkSmoothDuration)
		{
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429C")]
		[Address(RVA = "0x3639100", Offset = "0x3637700", VA = "0x183639100")]
		private static void SetupIkChain(IkTargetsController ikTargetsController, GameObject handTarget, GameObject elbowTarget, bool isRightHand, float handleIkSmoothDuration)
		{
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429D")]
		[Address(RVA = "0x36394E0", Offset = "0x3637AE0", VA = "0x1836394E0")]
		public IkTargetsController()
		{
		}

		// Token: 0x040045CD RID: 17869
		[Token(Token = "0x40045CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("FinalIK")]
		private LimbIK _leftHandLimb;

		// Token: 0x040045CE RID: 17870
		[Token(Token = "0x40045CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LimbIK _rightHandLimb;

		// Token: 0x040045CF RID: 17871
		[Token(Token = "0x40045CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BipedIK _bipped;

		// Token: 0x040045D0 RID: 17872
		[Token(Token = "0x40045D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Operations")]
		[SerializeField]
		private IkTargetsController.IkOperationAim _aimIKOperation;

		// Token: 0x040045D1 RID: 17873
		[Token(Token = "0x40045D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private IkTargetsController.IkOperationWeapon _weaponIKOperation;

		// Token: 0x040045D2 RID: 17874
		[Token(Token = "0x40045D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("_weaponBoneOnlyIKOperation")]
		private IkTargetsController.IkOperationHeldRenderer _leftHeldRendererOnlyIKOperation;

		// Token: 0x040045D3 RID: 17875
		[Token(Token = "0x40045D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("_weaponBoneOnlyIKOperation")]
		private IkTargetsController.IkOperationHeldRenderer _rightHeldRendererOnlyIKOperation;

		// Token: 0x040045D4 RID: 17876
		[Token(Token = "0x40045D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private IkTargetsController.IkOperationOffFakeBone _rightHandIKOperation;

		// Token: 0x040045D5 RID: 17877
		[Token(Token = "0x40045D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private IkTargetsController.IkOperationOffFakeBone _leftHandIKOperation;

		// Token: 0x040045D6 RID: 17878
		[Token(Token = "0x40045D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Settings")]
		[SerializeField]
		private float _smoothDuration;

		// Token: 0x040045D7 RID: 17879
		[Token(Token = "0x40045D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _stopIkSmoothDuration;

		// Token: 0x040045D8 RID: 17880
		[Token(Token = "0x40045D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _defaultRightElbowTarget;

		// Token: 0x040045D9 RID: 17881
		[Token(Token = "0x40045D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _defaultLeftElbowTarget;

		// Token: 0x040045DA RID: 17882
		[Token(Token = "0x40045DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<IkTargetsController.IkOperation> _activeOperations;

		// Token: 0x040045DB RID: 17883
		[Token(Token = "0x40045DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<IPostIKUpdater> _postIKUpdaters;

		// Token: 0x02000908 RID: 2312
		[Token(Token = "0x2000908")]
		[Serializable]
		public abstract class IkOperation
		{
			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x0600429E RID: 17054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000863")]
			public Transform IkTarget
			{
				[Token(Token = "0x600429E")]
				[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600429F RID: 17055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600429F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public virtual void Init()
			{
			}

			// Token: 0x060042A0 RID: 17056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A0")]
			[Address(RVA = "0x3639660", Offset = "0x3637C60", VA = "0x183639660")]
			public void BeginSmoothWeightUpdate(float delay, float posWeight, IKSolver solver)
			{
			}

			// Token: 0x060042A1 RID: 17057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A1")]
			[Address(RVA = "0x3639840", Offset = "0x3637E40", VA = "0x183639840")]
			public void SmoothWeightUpdate()
			{
			}

			// Token: 0x060042A2 RID: 17058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A2")]
			[Address(RVA = "0x36399C0", Offset = "0x3637FC0", VA = "0x1836399C0")]
			public void RelativePosRotUpdate()
			{
			}

			// Token: 0x060042A3 RID: 17059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A3")]
			[Address(RVA = "0x3639E60", Offset = "0x3638460", VA = "0x183639E60", Slot = "5")]
			protected virtual void ApplyWeight(float weight)
			{
			}

			// Token: 0x060042A4 RID: 17060
			[Token(Token = "0x60042A4")]
			public abstract void UpdateIK();

			// Token: 0x060042A5 RID: 17061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A5")]
			[Address(RVA = "0x3639F30", Offset = "0x3638530", VA = "0x183639F30")]
			public void Shutdown()
			{
			}

			// Token: 0x060042A6 RID: 17062 RVA: 0x000142E0 File Offset: 0x000124E0
			[Token(Token = "0x60042A6")]
			[Address(RVA = "0x3639FB0", Offset = "0x36385B0", VA = "0x183639FB0")]
			protected float GetSmoothDuration()
			{
				return 0f;
			}

			// Token: 0x060042A7 RID: 17063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A7")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
			protected virtual void OnBegin()
			{
			}

			// Token: 0x060042A8 RID: 17064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
			protected virtual void OnPostShutdown()
			{
			}

			// Token: 0x060042A9 RID: 17065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042A9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			protected IkOperation()
			{
			}

			// Token: 0x040045DC RID: 17884
			[Token(Token = "0x40045DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Header("Runtime State")]
			public bool _running;

			// Token: 0x040045DD RID: 17885
			[Token(Token = "0x40045DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IKSolver _solver;

			// Token: 0x040045DE RID: 17886
			[Token(Token = "0x40045DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IIkFakeBone _fakeBone;

			// Token: 0x040045DF RID: 17887
			[Token(Token = "0x40045DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float _activationTime;

			// Token: 0x040045E0 RID: 17888
			[Token(Token = "0x40045E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float _activeIkSmoothDuration;

			// Token: 0x040045E1 RID: 17889
			[Token(Token = "0x40045E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float _stopIkSmoothDuration;

			// Token: 0x040045E2 RID: 17890
			[Token(Token = "0x40045E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float _startPosWeight;

			// Token: 0x040045E3 RID: 17891
			[Token(Token = "0x40045E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float _targetPosWeight;

			// Token: 0x040045E4 RID: 17892
			[Token(Token = "0x40045E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float _currentWeight;

			// Token: 0x040045E5 RID: 17893
			[Token(Token = "0x40045E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform _relativeTo;

			// Token: 0x040045E6 RID: 17894
			[Token(Token = "0x40045E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 _relPos;

			// Token: 0x040045E7 RID: 17895
			[Token(Token = "0x40045E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Quaternion _relRot;

			// Token: 0x040045E8 RID: 17896
			[Token(Token = "0x40045E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform _relativeTo2;

			// Token: 0x040045E9 RID: 17897
			[Token(Token = "0x40045E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Vector3 _relativePos2;

			// Token: 0x040045EA RID: 17898
			[Token(Token = "0x40045EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[SerializeField]
			[Header("References")]
			protected Transform _ikTarget;
		}

		// Token: 0x02000909 RID: 2313
		[Token(Token = "0x2000909")]
		[Serializable]
		public class IkOperationOffFakeBone : IkTargetsController.IkOperation
		{
			// Token: 0x060042AA RID: 17066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042AA")]
			[Address(RVA = "0x3639FD0", Offset = "0x36385D0", VA = "0x183639FD0", Slot = "6")]
			public override void UpdateIK()
			{
			}

			// Token: 0x060042AB RID: 17067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042AB")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public IkOperationOffFakeBone()
			{
			}

			// Token: 0x040045EB RID: 17899
			[Token(Token = "0x40045EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 _handRelativePos;

			// Token: 0x040045EC RID: 17900
			[Token(Token = "0x40045EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion _handRelativeRot;
		}

		// Token: 0x0200090A RID: 2314
		[Token(Token = "0x200090A")]
		[Serializable]
		public class IkOperationAim : IkTargetsController.IkOperation
		{
			// Token: 0x060042AC RID: 17068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042AC")]
			[Address(RVA = "0x363A660", Offset = "0x3638C60", VA = "0x18363A660", Slot = "6")]
			public override void UpdateIK()
			{
			}

			// Token: 0x060042AD RID: 17069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public IkOperationAim()
			{
			}

			// Token: 0x040045ED RID: 17901
			[Token(Token = "0x40045ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform _mainTransform;

			// Token: 0x040045EE RID: 17902
			[Token(Token = "0x40045EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Vector3 _aimIkStartOffset;

			// Token: 0x040045EF RID: 17903
			[Token(Token = "0x40045EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public IkAimModes _aimModes;
		}

		// Token: 0x0200090B RID: 2315
		[Token(Token = "0x200090B")]
		[Serializable]
		public class IkOperationWeapon : IkTargetsController.IkOperation
		{
			// Token: 0x060042AE RID: 17070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042AE")]
			[Address(RVA = "0x363A800", Offset = "0x3638E00", VA = "0x18363A800", Slot = "5")]
			protected override void ApplyWeight(float weight)
			{
			}

			// Token: 0x060042AF RID: 17071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042AF")]
			[Address(RVA = "0x363A950", Offset = "0x3638F50", VA = "0x18363A950", Slot = "6")]
			public override void UpdateIK()
			{
			}

			// Token: 0x060042B0 RID: 17072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042B0")]
			[Address(RVA = "0x363B400", Offset = "0x3639A00", VA = "0x18363B400", Slot = "8")]
			protected override void OnPostShutdown()
			{
			}

			// Token: 0x060042B1 RID: 17073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042B1")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public IkOperationWeapon()
			{
			}

			// Token: 0x040045F0 RID: 17904
			[Token(Token = "0x40045F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[SerializeField]
			private Transform _leftHandBone;

			// Token: 0x040045F1 RID: 17905
			[Token(Token = "0x40045F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public IKSolver _leftHandSolver;

			// Token: 0x040045F2 RID: 17906
			[Token(Token = "0x40045F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public IKSolver _aimSolver;

			// Token: 0x040045F3 RID: 17907
			[Token(Token = "0x40045F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 _leftHandPosRelToRight;

			// Token: 0x040045F4 RID: 17908
			[Token(Token = "0x40045F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Quaternion _leftHandRotRelToRight;

			// Token: 0x040045F5 RID: 17909
			[Token(Token = "0x40045F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private Vector3 _rightHandRelativePos;

			// Token: 0x040045F6 RID: 17910
			[Token(Token = "0x40045F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private Quaternion _rightHandRelativeRot;
		}

		// Token: 0x0200090C RID: 2316
		[Token(Token = "0x200090C")]
		[Serializable]
		public class IkOperationHeldRenderer : IkTargetsController.IkOperation
		{
			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x060042B2 RID: 17074 RVA: 0x000142F8 File Offset: 0x000124F8
			// (set) Token: 0x060042B3 RID: 17075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000864")]
			public IkFilters Filter
			{
				[Token(Token = "0x60042B2")]
				[Address(RVA = "0x65E0E0", Offset = "0x65C6E0", VA = "0x18065E0E0")]
				[CompilerGenerated]
				get
				{
					return (IkFilters)0;
				}
				[Token(Token = "0x60042B3")]
				[Address(RVA = "0x65E0F0", Offset = "0x65C6F0", VA = "0x18065E0F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x060042B4 RID: 17076 RVA: 0x00014310 File Offset: 0x00012510
			[Token(Token = "0x17000865")]
			public bool ApplyPosition
			{
				[Token(Token = "0x60042B4")]
				[Address(RVA = "0x363B4B0", Offset = "0x3639AB0", VA = "0x18363B4B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x060042B5 RID: 17077 RVA: 0x00014328 File Offset: 0x00012528
			[Token(Token = "0x17000866")]
			public bool ApplyRotation
			{
				[Token(Token = "0x60042B5")]
				[Address(RVA = "0x363B4C0", Offset = "0x3639AC0", VA = "0x18363B4C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x060042B6 RID: 17078 RVA: 0x00014340 File Offset: 0x00012540
			[Token(Token = "0x17000867")]
			public bool ApplyScale
			{
				[Token(Token = "0x60042B6")]
				[Address(RVA = "0x363B4D0", Offset = "0x3639AD0", VA = "0x18363B4D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x060042B7 RID: 17079 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060042B8 RID: 17080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000868")]
			public IIkHeldRenderer HeldRenderer
			{
				[Token(Token = "0x60042B7")]
				[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60042B8")]
				[Address(RVA = "0x8DD110", Offset = "0x8DB710", VA = "0x1808DD110")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060042B9 RID: 17081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042B9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Init()
			{
			}

			// Token: 0x060042BA RID: 17082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042BA")]
			[Address(RVA = "0x363B4E0", Offset = "0x3639AE0", VA = "0x18363B4E0", Slot = "5")]
			protected override void ApplyWeight(float weight)
			{
			}

			// Token: 0x060042BB RID: 17083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042BB")]
			[Address(RVA = "0x363B510", Offset = "0x3639B10", VA = "0x18363B510", Slot = "6")]
			public override void UpdateIK()
			{
			}

			// Token: 0x060042BC RID: 17084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042BC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
			protected override void OnBegin()
			{
			}

			// Token: 0x060042BD RID: 17085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042BD")]
			[Address(RVA = "0x363BC90", Offset = "0x363A290", VA = "0x18363BC90", Slot = "8")]
			protected override void OnPostShutdown()
			{
			}

			// Token: 0x060042BE RID: 17086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042BE")]
			[Address(RVA = "0x363BCB0", Offset = "0x363A2B0", VA = "0x18363BCB0")]
			public void ClearHeldRenderer()
			{
			}

			// Token: 0x060042BF RID: 17087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042BF")]
			[Address(RVA = "0x363BD30", Offset = "0x363A330", VA = "0x18363BD30")]
			public IkOperationHeldRenderer()
			{
			}

			// Token: 0x040045F7 RID: 17911
			[Token(Token = "0x40045F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private float _weight;
		}
	}
}
