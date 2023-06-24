using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace TheForest.VR
{
	// Token: 0x0200039B RID: 923
	[Token(Token = "0x200039B")]
	[AddComponentMenu("TheForest/VR/VRPlayerControl")]
	public class VRPlayerControl : MonoBehaviour
	{
		// Token: 0x060018B6 RID: 6326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x32863A0", Offset = "0x32849A0", VA = "0x1832863A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x32864E0", Offset = "0x3284AE0", VA = "0x1832864E0")]
		private void Awake()
		{
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x3286710", Offset = "0x3284D10", VA = "0x183286710")]
		private void Start()
		{
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x32867E0", Offset = "0x3284DE0", VA = "0x1832867E0")]
		private void UpdateDisabledForGhostMode()
		{
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x3286CC0", Offset = "0x32852C0", VA = "0x183286CC0")]
		private void UpdateIconCameraVisibility()
		{
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x3286F30", Offset = "0x3285530", VA = "0x183286F30")]
		private static bool canUpdateMovement()
		{
			return default(bool);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x3287040", Offset = "0x3285640", VA = "0x183287040")]
		private void UpdateHandAttachments()
		{
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x3287620", Offset = "0x3285C20", VA = "0x183287620")]
		private void UpdateCrouchHeight()
		{
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x3287B00", Offset = "0x3286100", VA = "0x183287B00")]
		private void updateWeaponVis()
		{
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
		private Transform GetVRCameraOrigin()
		{
			return null;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void centerVrSpaceAroundHead()
		{
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x3287F40", Offset = "0x3286540", VA = "0x183287F40")]
		public IEnumerator centerVrSpaceAroundHeadAndMovePlayer()
		{
			return null;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void MovePlayerRelativeToVrPosition()
		{
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void rotateVrSpaceToPlayer()
		{
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x3287F80", Offset = "0x3286580", VA = "0x183287F80")]
		private void updateSpineRotation()
		{
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x3288A60", Offset = "0x3287060", VA = "0x183288A60")]
		private bool disableSpineInput()
		{
			return default(bool);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x3288B40", Offset = "0x3287140", VA = "0x183288B40")]
		public void EnableGuiCamera(bool enable)
		{
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x3288BF0", Offset = "0x32871F0", VA = "0x183288BF0")]
		private void UpdateFlick()
		{
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void UpdatePlayerAngleVr()
		{
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void RoomScaleCameraAlign()
		{
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018CA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void UpdateWeaponHandedness()
		{
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void ShowRespawnPrompt(bool onoff)
		{
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void ToggleVrControllers(bool onoff)
		{
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x268EE60", Offset = "0x268D460", VA = "0x18268EE60")]
		public float GetVRBowTension()
		{
			return 0f;
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void SetHandTracking(bool value)
		{
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x3288FE0", Offset = "0x32875E0", VA = "0x183288FE0")]
		public VRPlayerControl()
		{
		}

		// Token: 0x04001808 RID: 6152
		[Token(Token = "0x4001808")]
		private const float PhysicalCrouchHeightTrigger = 1.26f;

		// Token: 0x04001809 RID: 6153
		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0x20")]
		private InverseKinematics[] ikSolve;

		// Token: 0x0400180A RID: 6154
		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x28")]
		private VRCoopPlayerSync coopSync;

		// Token: 0x0400180B RID: 6155
		[Token(Token = "0x400180B")]
		[FieldOffset(Offset = "0x30")]
		public Transform ShellHeldTransform;

		// Token: 0x0400180C RID: 6156
		[Token(Token = "0x400180C")]
		[FieldOffset(Offset = "0x38")]
		public Transform ShellOrientTransform;

		// Token: 0x0400180D RID: 6157
		[Token(Token = "0x400180D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject VRLighterHeldGo;

		// Token: 0x0400180E RID: 6158
		[Token(Token = "0x400180E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject playerLighterHeldGo;

		// Token: 0x0400180F RID: 6159
		[Token(Token = "0x400180F")]
		[FieldOffset(Offset = "0x50")]
		public GameObject leftHandHeldGo;

		// Token: 0x04001810 RID: 6160
		[Token(Token = "0x4001810")]
		[FieldOffset(Offset = "0x58")]
		public GameObject laserPointerGo;

		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		[FieldOffset(Offset = "0x60")]
		public GameObject leftHandControllerGo;

		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		[FieldOffset(Offset = "0x68")]
		public GameObject RightHandControllerGo;

		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		[FieldOffset(Offset = "0x70")]
		public SkinnedMeshRenderer targetArmsRenderer;

		// Token: 0x04001814 RID: 6164
		[Token(Token = "0x4001814")]
		[FieldOffset(Offset = "0x78")]
		public SkinnedMeshRenderer VRArms;

		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		[FieldOffset(Offset = "0x80")]
		public SkinnedMeshRenderer DefaultArms;

		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		[FieldOffset(Offset = "0x88")]
		public Transform RotatableTransform;

		// Token: 0x04001817 RID: 6167
		[Token(Token = "0x4001817")]
		[FieldOffset(Offset = "0x90")]
		public Transform VRCamera;

		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		[FieldOffset(Offset = "0x98")]
		public Transform VRCameraOrigin;

		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		[FieldOffset(Offset = "0xA0")]
		public Transform VROffsetTransform;

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		[FieldOffset(Offset = "0xA8")]
		public Transform VRCameraRig;

		// Token: 0x0400181B RID: 6171
		[Token(Token = "0x400181B")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject VRLightableTrigger;

		// Token: 0x0400181C RID: 6172
		[Token(Token = "0x400181C")]
		[FieldOffset(Offset = "0xB8")]
		public Hand LeftHand;

		// Token: 0x0400181D RID: 6173
		[Token(Token = "0x400181D")]
		[FieldOffset(Offset = "0xC0")]
		public Hand RightHand;

		// Token: 0x0400181E RID: 6174
		[Token(Token = "0x400181E")]
		[FieldOffset(Offset = "0xC8")]
		public SteamVR_Behaviour_Pose LeftHandPose;

		// Token: 0x0400181F RID: 6175
		[Token(Token = "0x400181F")]
		[FieldOffset(Offset = "0xD0")]
		public SteamVR_Behaviour_Pose RightHandPose;

		// Token: 0x04001820 RID: 6176
		[Token(Token = "0x4001820")]
		[FieldOffset(Offset = "0xD8")]
		public Transform RightIkOffset;

		// Token: 0x04001821 RID: 6177
		[Token(Token = "0x4001821")]
		[FieldOffset(Offset = "0xE0")]
		public Transform LeftForearmTransform;

		// Token: 0x04001822 RID: 6178
		[Token(Token = "0x4001822")]
		[FieldOffset(Offset = "0xE8")]
		public Transform RightForearmTransform;

		// Token: 0x04001823 RID: 6179
		[Token(Token = "0x4001823")]
		[FieldOffset(Offset = "0xF0")]
		public Transform LeftHandIkScaleTransform;

		// Token: 0x04001824 RID: 6180
		[Token(Token = "0x4001824")]
		[FieldOffset(Offset = "0xF8")]
		public Transform RightHandIkScaleTransform;

		// Token: 0x04001825 RID: 6181
		[Token(Token = "0x4001825")]
		[FieldOffset(Offset = "0x100")]
		public Transform LeftActionButtons;

		// Token: 0x04001826 RID: 6182
		[Token(Token = "0x4001826")]
		[FieldOffset(Offset = "0x108")]
		public Transform RightActionButtons;

		// Token: 0x04001827 RID: 6183
		[Token(Token = "0x4001827")]
		[FieldOffset(Offset = "0x110")]
		public bool HorizontalFlickable;

		// Token: 0x04001828 RID: 6184
		[Token(Token = "0x4001828")]
		[FieldOffset(Offset = "0x114")]
		public float HorizontalDeadzone;

		// Token: 0x04001829 RID: 6185
		[Token(Token = "0x4001829")]
		[FieldOffset(Offset = "0x118")]
		public bool VerticalFlickable;

		// Token: 0x0400182A RID: 6186
		[Token(Token = "0x400182A")]
		[FieldOffset(Offset = "0x11C")]
		public float VerticalDeadzone;

		// Token: 0x0400182B RID: 6187
		[Token(Token = "0x400182B")]
		[FieldOffset(Offset = "0x120")]
		private bool switchArmsCheck;

		// Token: 0x0400182C RID: 6188
		[Token(Token = "0x400182C")]
		[FieldOffset(Offset = "0x121")]
		private bool canSolveIk;

		// Token: 0x0400182D RID: 6189
		[Token(Token = "0x400182D")]
		[FieldOffset(Offset = "0x122")]
		public bool useGhostMode;

		// Token: 0x0400182E RID: 6190
		[Token(Token = "0x400182E")]
		[FieldOffset(Offset = "0x128")]
		public List<GameObject> DisableInGhostMode;

		// Token: 0x0400182F RID: 6191
		[Token(Token = "0x400182F")]
		[FieldOffset(Offset = "0x130")]
		private bool _processedDisabledInGhostMode;

		// Token: 0x04001830 RID: 6192
		[Token(Token = "0x4001830")]
		[FieldOffset(Offset = "0x138")]
		private List<GameObject> _trackedDisabledInGhostMode;

		// Token: 0x04001831 RID: 6193
		[Token(Token = "0x4001831")]
		[FieldOffset(Offset = "0x140")]
		public VRPlayerAdapter VRPlayerAdapter;

		// Token: 0x04001832 RID: 6194
		[Token(Token = "0x4001832")]
		[FieldOffset(Offset = "0x148")]
		private bool inventoryOpen;

		// Token: 0x04001833 RID: 6195
		[Token(Token = "0x4001833")]
		[FieldOffset(Offset = "0x149")]
		private bool createGhostMode;

		// Token: 0x04001834 RID: 6196
		[Token(Token = "0x4001834")]
		[FieldOffset(Offset = "0x14A")]
		private bool pauseMenuMode;

		// Token: 0x04001835 RID: 6197
		[Token(Token = "0x4001835")]
		[FieldOffset(Offset = "0x14C")]
		private float OriginHeight;

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x150")]
		private Vector3 watchParentLocalPos;

		// Token: 0x04001837 RID: 6199
		[Token(Token = "0x4001837")]
		[FieldOffset(Offset = "0x15C")]
		private Quaternion watchParentLocalRot;

		// Token: 0x04001838 RID: 6200
		[Token(Token = "0x4001838")]
		[FieldOffset(Offset = "0x16C")]
		private Vector3 watchParentLocalScale;

		// Token: 0x04001839 RID: 6201
		[Token(Token = "0x4001839")]
		[FieldOffset(Offset = "0x178")]
		private Vector3 shellLocalPos;

		// Token: 0x0400183A RID: 6202
		[Token(Token = "0x400183A")]
		[FieldOffset(Offset = "0x184")]
		private Quaternion shellLocalRot;

		// Token: 0x0400183B RID: 6203
		[Token(Token = "0x400183B")]
		[FieldOffset(Offset = "0x194")]
		private bool doingCrouch;

		// Token: 0x0400183C RID: 6204
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x195")]
		public bool _startedMoving;

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x196")]
		[HideInInspector]
		public bool toggleCrouchFromVrHeight;

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x198")]
		public Transform[] spineBones;

		// Token: 0x0400183F RID: 6207
		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0x1A0")]
		public Transform followTarget;

		// Token: 0x04001840 RID: 6208
		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0x1A8")]
		public Transform headTransform;

		// Token: 0x04001841 RID: 6209
		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0x1B0")]
		public float xClampValue;

		// Token: 0x04001842 RID: 6210
		[Token(Token = "0x4001842")]
		[FieldOffset(Offset = "0x1B4")]
		public float zClampValue;

		// Token: 0x04001843 RID: 6211
		[Token(Token = "0x4001843")]
		[FieldOffset(Offset = "0x1B8")]
		public float spineBendAmount;

		// Token: 0x04001844 RID: 6212
		[Token(Token = "0x4001844")]
		[FieldOffset(Offset = "0x1BC")]
		public float spineTwistAmount;

		// Token: 0x04001845 RID: 6213
		[Token(Token = "0x4001845")]
		[FieldOffset(Offset = "0x1C0")]
		public float fudgeOffsetCameraValue;

		// Token: 0x04001846 RID: 6214
		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x1C4")]
		private float heightResetTimer;

		// Token: 0x04001847 RID: 6215
		[Token(Token = "0x4001847")]
		[FieldOffset(Offset = "0x1C8")]
		private float distanceResetTimer;

		// Token: 0x04001848 RID: 6216
		[Token(Token = "0x4001848")]
		[FieldOffset(Offset = "0x1CC")]
		private float smoothTargetAngle;

		// Token: 0x04001849 RID: 6217
		[Token(Token = "0x4001849")]
		[FieldOffset(Offset = "0x1D0")]
		private float spineBendClamp;

		// Token: 0x0400184A RID: 6218
		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x1D4")]
		public float MovePlayerThreshold;

		// Token: 0x0400184B RID: 6219
		[Token(Token = "0x400184B")]
		[FieldOffset(Offset = "0x1D8")]
		public VRPlayerBlockedEffect BlockedEffect;

		// Token: 0x0400184C RID: 6220
		[Token(Token = "0x400184C")]
		[FieldOffset(Offset = "0x1E0")]
		private Vector3 velRef;

		// Token: 0x0400184D RID: 6221
		[Token(Token = "0x400184D")]
		[FieldOffset(Offset = "0x1EC")]
		private Vector3 smoothPosition;

		// Token: 0x0400184E RID: 6222
		[Token(Token = "0x400184E")]
		[FieldOffset(Offset = "0x1F8")]
		private Vector3 smoothClampedTargetPosition;

		// Token: 0x0400184F RID: 6223
		[Token(Token = "0x400184F")]
		[FieldOffset(Offset = "0x204")]
		private Vector2 lastAim;

		// Token: 0x04001850 RID: 6224
		[Token(Token = "0x4001850")]
		[FieldOffset(Offset = "0x20C")]
		public bool RightHandedActive;
	}
}
