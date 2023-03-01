using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace TheForest.VR
{
	// Token: 0x020003A9 RID: 937
	[Token(Token = "0x20003A9")]
	[AddComponentMenu("TheForest/VR/VRPlayerControl")]
	public class VRPlayerControl : MonoBehaviour
	{
		// Token: 0x0600187B RID: 6267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x2CD7110", Offset = "0x2CD6110", VA = "0x182CD7110")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187C")]
		[Address(RVA = "0x2CD6FD0", Offset = "0x2CD5FD0", VA = "0x182CD6FD0")]
		private void Awake()
		{
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187D")]
		[Address(RVA = "0x2CD71B0", Offset = "0x2CD61B0", VA = "0x182CD71B0")]
		private void Start()
		{
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187E")]
		[Address(RVA = "0x2CD7530", Offset = "0x2CD6530", VA = "0x182CD7530")]
		private void UpdateDisabledForGhostMode()
		{
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x2CD8040", Offset = "0x2CD7040", VA = "0x182CD8040")]
		private void UpdateIconCameraVisibility()
		{
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x6001880")]
		[Address(RVA = "0x2CD8280", Offset = "0x2CD7280", VA = "0x182CD8280")]
		private static bool canUpdateMovement()
		{
			return default(bool);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001881")]
		[Address(RVA = "0x2CD7D20", Offset = "0x2CD6D20", VA = "0x182CD7D20")]
		private void UpdateHandAttachments()
		{
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001882")]
		[Address(RVA = "0x2CD7240", Offset = "0x2CD6240", VA = "0x182CD7240")]
		private void UpdateCrouchHeight()
		{
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001883")]
		[Address(RVA = "0x2CD8CB0", Offset = "0x2CD7CB0", VA = "0x182CD8CB0")]
		private void updateWeaponVis()
		{
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001884")]
		[Address(RVA = "0x6AC8B0", Offset = "0x6AB8B0", VA = "0x1806AC8B0")]
		private Transform GetVRCameraOrigin()
		{
			return null;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001885")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void centerVrSpaceAroundHead()
		{
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x2CD83B0", Offset = "0x2CD73B0", VA = "0x182CD83B0")]
		public IEnumerator centerVrSpaceAroundHeadAndMovePlayer()
		{
			return null;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001887")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void MovePlayerRelativeToVrPosition()
		{
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001888")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void rotateVrSpaceToPlayer()
		{
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001889")]
		[Address(RVA = "0x2CD84E0", Offset = "0x2CD74E0", VA = "0x182CD84E0")]
		private void updateSpineRotation()
		{
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x600188A")]
		[Address(RVA = "0x2CD8400", Offset = "0x2CD7400", VA = "0x182CD8400")]
		private bool disableSpineInput()
		{
			return default(bool);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188B")]
		[Address(RVA = "0x2CD70A0", Offset = "0x2CD60A0", VA = "0x182CD70A0")]
		public void EnableGuiCamera(bool enable)
		{
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x2CD78C0", Offset = "0x2CD68C0", VA = "0x182CD78C0")]
		private void UpdateFlick()
		{
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void UpdatePlayerAngleVr()
		{
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void RoomScaleCameraAlign()
		{
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void UpdateWeaponHandedness()
		{
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001890")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void ShowRespawnPrompt(bool onoff)
		{
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001891")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void ToggleVrControllers(bool onoff)
		{
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x6001892")]
		[Address(RVA = "0x225D330", Offset = "0x225C330", VA = "0x18225D330")]
		public float GetVRBowTension()
		{
			return default(float);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void SetHandTracking(bool value)
		{
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x2CD81E0", Offset = "0x2CD71E0", VA = "0x182CD81E0")]
		public VRPlayerControl()
		{
		}

		// Token: 0x040017E9 RID: 6121
		[Token(Token = "0x40017E9")]
		private const float PhysicalCrouchHeightTrigger = 1.26f;

		// Token: 0x040017EA RID: 6122
		[Token(Token = "0x40017EA")]
		[FieldOffset(Offset = "0x20")]
		private InverseKinematics[] ikSolve;

		// Token: 0x040017EB RID: 6123
		[Token(Token = "0x40017EB")]
		[FieldOffset(Offset = "0x28")]
		private VRCoopPlayerSync coopSync;

		// Token: 0x040017EC RID: 6124
		[Token(Token = "0x40017EC")]
		[FieldOffset(Offset = "0x30")]
		public Transform ShellHeldTransform;

		// Token: 0x040017ED RID: 6125
		[Token(Token = "0x40017ED")]
		[FieldOffset(Offset = "0x38")]
		public Transform ShellOrientTransform;

		// Token: 0x040017EE RID: 6126
		[Token(Token = "0x40017EE")]
		[FieldOffset(Offset = "0x40")]
		public GameObject VRLighterHeldGo;

		// Token: 0x040017EF RID: 6127
		[Token(Token = "0x40017EF")]
		[FieldOffset(Offset = "0x48")]
		public GameObject playerLighterHeldGo;

		// Token: 0x040017F0 RID: 6128
		[Token(Token = "0x40017F0")]
		[FieldOffset(Offset = "0x50")]
		public GameObject leftHandHeldGo;

		// Token: 0x040017F1 RID: 6129
		[Token(Token = "0x40017F1")]
		[FieldOffset(Offset = "0x58")]
		public GameObject laserPointerGo;

		// Token: 0x040017F2 RID: 6130
		[Token(Token = "0x40017F2")]
		[FieldOffset(Offset = "0x60")]
		public GameObject leftHandControllerGo;

		// Token: 0x040017F3 RID: 6131
		[Token(Token = "0x40017F3")]
		[FieldOffset(Offset = "0x68")]
		public GameObject RightHandControllerGo;

		// Token: 0x040017F4 RID: 6132
		[Token(Token = "0x40017F4")]
		[FieldOffset(Offset = "0x70")]
		public SkinnedMeshRenderer targetArmsRenderer;

		// Token: 0x040017F5 RID: 6133
		[Token(Token = "0x40017F5")]
		[FieldOffset(Offset = "0x78")]
		public SkinnedMeshRenderer VRArms;

		// Token: 0x040017F6 RID: 6134
		[Token(Token = "0x40017F6")]
		[FieldOffset(Offset = "0x80")]
		public SkinnedMeshRenderer DefaultArms;

		// Token: 0x040017F7 RID: 6135
		[Token(Token = "0x40017F7")]
		[FieldOffset(Offset = "0x88")]
		public Transform RotatableTransform;

		// Token: 0x040017F8 RID: 6136
		[Token(Token = "0x40017F8")]
		[FieldOffset(Offset = "0x90")]
		public Transform VRCamera;

		// Token: 0x040017F9 RID: 6137
		[Token(Token = "0x40017F9")]
		[FieldOffset(Offset = "0x98")]
		public Transform VRCameraOrigin;

		// Token: 0x040017FA RID: 6138
		[Token(Token = "0x40017FA")]
		[FieldOffset(Offset = "0xA0")]
		public Transform VROffsetTransform;

		// Token: 0x040017FB RID: 6139
		[Token(Token = "0x40017FB")]
		[FieldOffset(Offset = "0xA8")]
		public Transform VRCameraRig;

		// Token: 0x040017FC RID: 6140
		[Token(Token = "0x40017FC")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject VRLightableTrigger;

		// Token: 0x040017FD RID: 6141
		[Token(Token = "0x40017FD")]
		[FieldOffset(Offset = "0xB8")]
		public Hand LeftHand;

		// Token: 0x040017FE RID: 6142
		[Token(Token = "0x40017FE")]
		[FieldOffset(Offset = "0xC0")]
		public Hand RightHand;

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		[FieldOffset(Offset = "0xC8")]
		public SteamVR_Behaviour_Pose LeftHandPose;

		// Token: 0x04001800 RID: 6144
		[Token(Token = "0x4001800")]
		[FieldOffset(Offset = "0xD0")]
		public SteamVR_Behaviour_Pose RightHandPose;

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		[FieldOffset(Offset = "0xD8")]
		public Transform RightIkOffset;

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		[FieldOffset(Offset = "0xE0")]
		public Transform LeftForearmTransform;

		// Token: 0x04001803 RID: 6147
		[Token(Token = "0x4001803")]
		[FieldOffset(Offset = "0xE8")]
		public Transform RightForearmTransform;

		// Token: 0x04001804 RID: 6148
		[Token(Token = "0x4001804")]
		[FieldOffset(Offset = "0xF0")]
		public Transform LeftHandIkScaleTransform;

		// Token: 0x04001805 RID: 6149
		[Token(Token = "0x4001805")]
		[FieldOffset(Offset = "0xF8")]
		public Transform RightHandIkScaleTransform;

		// Token: 0x04001806 RID: 6150
		[Token(Token = "0x4001806")]
		[FieldOffset(Offset = "0x100")]
		public Transform LeftActionButtons;

		// Token: 0x04001807 RID: 6151
		[Token(Token = "0x4001807")]
		[FieldOffset(Offset = "0x108")]
		public Transform RightActionButtons;

		// Token: 0x04001808 RID: 6152
		[Token(Token = "0x4001808")]
		[FieldOffset(Offset = "0x110")]
		public bool HorizontalFlickable;

		// Token: 0x04001809 RID: 6153
		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0x114")]
		public float HorizontalDeadzone;

		// Token: 0x0400180A RID: 6154
		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x118")]
		public bool VerticalFlickable;

		// Token: 0x0400180B RID: 6155
		[Token(Token = "0x400180B")]
		[FieldOffset(Offset = "0x11C")]
		public float VerticalDeadzone;

		// Token: 0x0400180C RID: 6156
		[Token(Token = "0x400180C")]
		[FieldOffset(Offset = "0x120")]
		private bool switchArmsCheck;

		// Token: 0x0400180D RID: 6157
		[Token(Token = "0x400180D")]
		[FieldOffset(Offset = "0x121")]
		private bool canSolveIk;

		// Token: 0x0400180E RID: 6158
		[Token(Token = "0x400180E")]
		[FieldOffset(Offset = "0x122")]
		public bool useGhostMode;

		// Token: 0x0400180F RID: 6159
		[Token(Token = "0x400180F")]
		[FieldOffset(Offset = "0x128")]
		public List<GameObject> DisableInGhostMode;

		// Token: 0x04001810 RID: 6160
		[Token(Token = "0x4001810")]
		[FieldOffset(Offset = "0x130")]
		private bool _processedDisabledInGhostMode;

		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		[FieldOffset(Offset = "0x138")]
		private List<GameObject> _trackedDisabledInGhostMode;

		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		[FieldOffset(Offset = "0x140")]
		public VRPlayerAdapter VRPlayerAdapter;

		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		[FieldOffset(Offset = "0x148")]
		private bool inventoryOpen;

		// Token: 0x04001814 RID: 6164
		[Token(Token = "0x4001814")]
		[FieldOffset(Offset = "0x149")]
		private bool createGhostMode;

		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		[FieldOffset(Offset = "0x14A")]
		private bool pauseMenuMode;

		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		[FieldOffset(Offset = "0x14C")]
		private float OriginHeight;

		// Token: 0x04001817 RID: 6167
		[Token(Token = "0x4001817")]
		[FieldOffset(Offset = "0x150")]
		private Vector3 watchParentLocalPos;

		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		[FieldOffset(Offset = "0x15C")]
		private Quaternion watchParentLocalRot;

		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		[FieldOffset(Offset = "0x16C")]
		private Vector3 watchParentLocalScale;

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		[FieldOffset(Offset = "0x178")]
		private Vector3 shellLocalPos;

		// Token: 0x0400181B RID: 6171
		[Token(Token = "0x400181B")]
		[FieldOffset(Offset = "0x184")]
		private Quaternion shellLocalRot;

		// Token: 0x0400181C RID: 6172
		[Token(Token = "0x400181C")]
		[FieldOffset(Offset = "0x194")]
		private bool doingCrouch;

		// Token: 0x0400181D RID: 6173
		[Token(Token = "0x400181D")]
		[FieldOffset(Offset = "0x195")]
		public bool _startedMoving;

		// Token: 0x0400181E RID: 6174
		[Token(Token = "0x400181E")]
		[FieldOffset(Offset = "0x196")]
		[HideInInspector]
		public bool toggleCrouchFromVrHeight;

		// Token: 0x0400181F RID: 6175
		[Token(Token = "0x400181F")]
		[FieldOffset(Offset = "0x198")]
		public Transform[] spineBones;

		// Token: 0x04001820 RID: 6176
		[Token(Token = "0x4001820")]
		[FieldOffset(Offset = "0x1A0")]
		public Transform followTarget;

		// Token: 0x04001821 RID: 6177
		[Token(Token = "0x4001821")]
		[FieldOffset(Offset = "0x1A8")]
		public Transform headTransform;

		// Token: 0x04001822 RID: 6178
		[Token(Token = "0x4001822")]
		[FieldOffset(Offset = "0x1B0")]
		public float xClampValue;

		// Token: 0x04001823 RID: 6179
		[Token(Token = "0x4001823")]
		[FieldOffset(Offset = "0x1B4")]
		public float zClampValue;

		// Token: 0x04001824 RID: 6180
		[Token(Token = "0x4001824")]
		[FieldOffset(Offset = "0x1B8")]
		public float spineBendAmount;

		// Token: 0x04001825 RID: 6181
		[Token(Token = "0x4001825")]
		[FieldOffset(Offset = "0x1BC")]
		public float spineTwistAmount;

		// Token: 0x04001826 RID: 6182
		[Token(Token = "0x4001826")]
		[FieldOffset(Offset = "0x1C0")]
		public float fudgeOffsetCameraValue;

		// Token: 0x04001827 RID: 6183
		[Token(Token = "0x4001827")]
		[FieldOffset(Offset = "0x1C4")]
		private float heightResetTimer;

		// Token: 0x04001828 RID: 6184
		[Token(Token = "0x4001828")]
		[FieldOffset(Offset = "0x1C8")]
		private float distanceResetTimer;

		// Token: 0x04001829 RID: 6185
		[Token(Token = "0x4001829")]
		[FieldOffset(Offset = "0x1CC")]
		private float smoothTargetAngle;

		// Token: 0x0400182A RID: 6186
		[Token(Token = "0x400182A")]
		[FieldOffset(Offset = "0x1D0")]
		private float spineBendClamp;

		// Token: 0x0400182B RID: 6187
		[Token(Token = "0x400182B")]
		[FieldOffset(Offset = "0x1D4")]
		public float MovePlayerThreshold;

		// Token: 0x0400182C RID: 6188
		[Token(Token = "0x400182C")]
		[FieldOffset(Offset = "0x1D8")]
		public VRPlayerBlockedEffect BlockedEffect;

		// Token: 0x0400182D RID: 6189
		[Token(Token = "0x400182D")]
		[FieldOffset(Offset = "0x1E0")]
		private Vector3 velRef;

		// Token: 0x0400182E RID: 6190
		[Token(Token = "0x400182E")]
		[FieldOffset(Offset = "0x1EC")]
		private Vector3 smoothPosition;

		// Token: 0x0400182F RID: 6191
		[Token(Token = "0x400182F")]
		[FieldOffset(Offset = "0x1F8")]
		private Vector3 smoothClampedTargetPosition;

		// Token: 0x04001830 RID: 6192
		[Token(Token = "0x4001830")]
		[FieldOffset(Offset = "0x204")]
		private Vector2 lastAim;

		// Token: 0x04001831 RID: 6193
		[Token(Token = "0x4001831")]
		[FieldOffset(Offset = "0x20C")]
		public bool RightHandedActive;
	}
}
