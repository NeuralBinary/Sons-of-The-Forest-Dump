using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.VR
{
	// Token: 0x0200039A RID: 922
	[Token(Token = "0x200039A")]
	[AddComponentMenu("TheForest/VR/VRPlayerAdapter")]
	public class VRPlayerAdapter : MonoBehaviour
	{
		// Token: 0x060018B1 RID: 6321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnValidate()
		{
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x3286200", Offset = "0x3284800", VA = "0x183286200")]
		private void Awake()
		{
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x32862E0", Offset = "0x32848E0", VA = "0x1832862E0")]
		private void Start()
		{
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x32862E0", Offset = "0x32848E0", VA = "0x1832862E0")]
		private void ConvertToVR()
		{
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VRPlayerAdapter()
		{
		}

		// Token: 0x040017E8 RID: 6120
		[Token(Token = "0x40017E8")]
		[FieldOffset(Offset = "0x20")]
		public VRTheatreController TheatreController;

		// Token: 0x040017E9 RID: 6121
		[Token(Token = "0x40017E9")]
		[FieldOffset(Offset = "0x28")]
		public GameObject MainCamera;

		// Token: 0x040017EA RID: 6122
		[Token(Token = "0x40017EA")]
		[FieldOffset(Offset = "0x30")]
		public GameObject VRCameraRig;

		// Token: 0x040017EB RID: 6123
		[Token(Token = "0x40017EB")]
		[FieldOffset(Offset = "0x38")]
		public GameObject VREyeCamera;

		// Token: 0x040017EC RID: 6124
		[Token(Token = "0x40017EC")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Player;

		// Token: 0x040017ED RID: 6125
		[Token(Token = "0x40017ED")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PlayerBase;

		// Token: 0x040017EE RID: 6126
		[Token(Token = "0x40017EE")]
		[FieldOffset(Offset = "0x50")]
		public GameObject cameraChildren;

		// Token: 0x040017EF RID: 6127
		[Token(Token = "0x40017EF")]
		[FieldOffset(Offset = "0x58")]
		public GameObject mouthPiece;

		// Token: 0x040017F0 RID: 6128
		[Token(Token = "0x40017F0")]
		[FieldOffset(Offset = "0x60")]
		public GameObject RightWeaponOffset;

		// Token: 0x040017F1 RID: 6129
		[Token(Token = "0x40017F1")]
		[FieldOffset(Offset = "0x68")]
		public GameObject VRWatchGo;

		// Token: 0x040017F2 RID: 6130
		[Token(Token = "0x40017F2")]
		[FieldOffset(Offset = "0x70")]
		public GameObject VRWatchParentGo;

		// Token: 0x040017F3 RID: 6131
		[Token(Token = "0x40017F3")]
		[FieldOffset(Offset = "0x78")]
		public GameObject[] tempHands;

		// Token: 0x040017F4 RID: 6132
		[Token(Token = "0x40017F4")]
		[FieldOffset(Offset = "0x80")]
		public GameObject grassDisplacementGo;

		// Token: 0x040017F5 RID: 6133
		[Token(Token = "0x40017F5")]
		[FieldOffset(Offset = "0x88")]
		public GameObject heldDeadBodyGo;

		// Token: 0x040017F6 RID: 6134
		[Token(Token = "0x40017F6")]
		[FieldOffset(Offset = "0x90")]
		public GameObject HeightScaleGo;

		// Token: 0x040017F7 RID: 6135
		[Token(Token = "0x40017F7")]
		[FieldOffset(Offset = "0x98")]
		public GameObject HeadHeightScaleGo;

		// Token: 0x040017F8 RID: 6136
		[Token(Token = "0x40017F8")]
		[FieldOffset(Offset = "0xA0")]
		public Transform overShoulderCamPos;

		// Token: 0x040017F9 RID: 6137
		[Token(Token = "0x40017F9")]
		[FieldOffset(Offset = "0xA8")]
		public Transform dragAwayCamPos;

		// Token: 0x040017FA RID: 6138
		[Token(Token = "0x40017FA")]
		[FieldOffset(Offset = "0xB0")]
		public Transform behindCamPos;

		// Token: 0x040017FB RID: 6139
		[Token(Token = "0x40017FB")]
		[FieldOffset(Offset = "0xB8")]
		public Transform behindClientCamPos;

		// Token: 0x040017FC RID: 6140
		[Token(Token = "0x40017FC")]
		[FieldOffset(Offset = "0xC0")]
		public Transform JointsOffsetTransform;

		// Token: 0x040017FD RID: 6141
		[Token(Token = "0x40017FD")]
		[FieldOffset(Offset = "0xC8")]
		public Transform heldLogsParentTransform;

		// Token: 0x040017FE RID: 6142
		[Token(Token = "0x40017FE")]
		[FieldOffset(Offset = "0xD0")]
		public Transform cameraChildOffsetTranform;

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		[FieldOffset(Offset = "0xD8")]
		public bool BindCamHead;

		// Token: 0x04001800 RID: 6144
		[Token(Token = "0x4001800")]
		[FieldOffset(Offset = "0xD9")]
		public bool BindNewHeight;

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		[FieldOffset(Offset = "0xDA")]
		public bool BindScale;

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject[] PlayerMeshesToDisable;

		// Token: 0x04001803 RID: 6147
		[Token(Token = "0x4001803")]
		[FieldOffset(Offset = "0xE8")]
		public Renderer PlayerHead1;

		// Token: 0x04001804 RID: 6148
		[Token(Token = "0x4001804")]
		[FieldOffset(Offset = "0xF0")]
		public Renderer VRPlayerHands;

		// Token: 0x04001805 RID: 6149
		[Token(Token = "0x4001805")]
		[FieldOffset(Offset = "0xF8")]
		public Renderer defaultPlayerArms;

		// Token: 0x04001806 RID: 6150
		[Token(Token = "0x4001806")]
		[FieldOffset(Offset = "0x100")]
		public Renderer[] PlayerShadowOnly;

		// Token: 0x04001807 RID: 6151
		[Token(Token = "0x4001807")]
		[FieldOffset(Offset = "0x108")]
		public LayerMask OptionsMenuLayerMask;
	}
}
