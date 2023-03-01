using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.VR
{
	// Token: 0x020003A8 RID: 936
	[Token(Token = "0x20003A8")]
	[AddComponentMenu("TheForest/VR/VRPlayerAdapter")]
	public class VRPlayerAdapter : MonoBehaviour
	{
		// Token: 0x06001876 RID: 6262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void OnValidate()
		{
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x2CD6F30", Offset = "0x2CD5F30", VA = "0x182CD6F30")]
		private void Awake()
		{
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x2CD6F90", Offset = "0x2CD5F90", VA = "0x182CD6F90")]
		private void Start()
		{
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x2CD6F90", Offset = "0x2CD5F90", VA = "0x182CD6F90")]
		private void ConvertToVR()
		{
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187A")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public VRPlayerAdapter()
		{
		}

		// Token: 0x040017C9 RID: 6089
		[Token(Token = "0x40017C9")]
		[FieldOffset(Offset = "0x20")]
		public VRTheatreController TheatreController;

		// Token: 0x040017CA RID: 6090
		[Token(Token = "0x40017CA")]
		[FieldOffset(Offset = "0x28")]
		public GameObject MainCamera;

		// Token: 0x040017CB RID: 6091
		[Token(Token = "0x40017CB")]
		[FieldOffset(Offset = "0x30")]
		public GameObject VRCameraRig;

		// Token: 0x040017CC RID: 6092
		[Token(Token = "0x40017CC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject VREyeCamera;

		// Token: 0x040017CD RID: 6093
		[Token(Token = "0x40017CD")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Player;

		// Token: 0x040017CE RID: 6094
		[Token(Token = "0x40017CE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PlayerBase;

		// Token: 0x040017CF RID: 6095
		[Token(Token = "0x40017CF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject cameraChildren;

		// Token: 0x040017D0 RID: 6096
		[Token(Token = "0x40017D0")]
		[FieldOffset(Offset = "0x58")]
		public GameObject mouthPiece;

		// Token: 0x040017D1 RID: 6097
		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x60")]
		public GameObject RightWeaponOffset;

		// Token: 0x040017D2 RID: 6098
		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x68")]
		public GameObject VRWatchGo;

		// Token: 0x040017D3 RID: 6099
		[Token(Token = "0x40017D3")]
		[FieldOffset(Offset = "0x70")]
		public GameObject VRWatchParentGo;

		// Token: 0x040017D4 RID: 6100
		[Token(Token = "0x40017D4")]
		[FieldOffset(Offset = "0x78")]
		public GameObject[] tempHands;

		// Token: 0x040017D5 RID: 6101
		[Token(Token = "0x40017D5")]
		[FieldOffset(Offset = "0x80")]
		public GameObject grassDisplacementGo;

		// Token: 0x040017D6 RID: 6102
		[Token(Token = "0x40017D6")]
		[FieldOffset(Offset = "0x88")]
		public GameObject heldDeadBodyGo;

		// Token: 0x040017D7 RID: 6103
		[Token(Token = "0x40017D7")]
		[FieldOffset(Offset = "0x90")]
		public GameObject HeightScaleGo;

		// Token: 0x040017D8 RID: 6104
		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0x98")]
		public GameObject HeadHeightScaleGo;

		// Token: 0x040017D9 RID: 6105
		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0xA0")]
		public Transform overShoulderCamPos;

		// Token: 0x040017DA RID: 6106
		[Token(Token = "0x40017DA")]
		[FieldOffset(Offset = "0xA8")]
		public Transform dragAwayCamPos;

		// Token: 0x040017DB RID: 6107
		[Token(Token = "0x40017DB")]
		[FieldOffset(Offset = "0xB0")]
		public Transform behindCamPos;

		// Token: 0x040017DC RID: 6108
		[Token(Token = "0x40017DC")]
		[FieldOffset(Offset = "0xB8")]
		public Transform behindClientCamPos;

		// Token: 0x040017DD RID: 6109
		[Token(Token = "0x40017DD")]
		[FieldOffset(Offset = "0xC0")]
		public Transform JointsOffsetTransform;

		// Token: 0x040017DE RID: 6110
		[Token(Token = "0x40017DE")]
		[FieldOffset(Offset = "0xC8")]
		public Transform heldLogsParentTransform;

		// Token: 0x040017DF RID: 6111
		[Token(Token = "0x40017DF")]
		[FieldOffset(Offset = "0xD0")]
		public Transform cameraChildOffsetTranform;

		// Token: 0x040017E0 RID: 6112
		[Token(Token = "0x40017E0")]
		[FieldOffset(Offset = "0xD8")]
		public bool BindCamHead;

		// Token: 0x040017E1 RID: 6113
		[Token(Token = "0x40017E1")]
		[FieldOffset(Offset = "0xD9")]
		public bool BindNewHeight;

		// Token: 0x040017E2 RID: 6114
		[Token(Token = "0x40017E2")]
		[FieldOffset(Offset = "0xDA")]
		public bool BindScale;

		// Token: 0x040017E3 RID: 6115
		[Token(Token = "0x40017E3")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject[] PlayerMeshesToDisable;

		// Token: 0x040017E4 RID: 6116
		[Token(Token = "0x40017E4")]
		[FieldOffset(Offset = "0xE8")]
		public Renderer PlayerHead1;

		// Token: 0x040017E5 RID: 6117
		[Token(Token = "0x40017E5")]
		[FieldOffset(Offset = "0xF0")]
		public Renderer VRPlayerHands;

		// Token: 0x040017E6 RID: 6118
		[Token(Token = "0x40017E6")]
		[FieldOffset(Offset = "0xF8")]
		public Renderer defaultPlayerArms;

		// Token: 0x040017E7 RID: 6119
		[Token(Token = "0x40017E7")]
		[FieldOffset(Offset = "0x100")]
		public Renderer[] PlayerShadowOnly;

		// Token: 0x040017E8 RID: 6120
		[Token(Token = "0x40017E8")]
		[FieldOffset(Offset = "0x108")]
		public LayerMask OptionsMenuLayerMask;
	}
}
