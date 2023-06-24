using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace NWH.Common.Cameras
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class CameraChanger : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x26E37F0", Offset = "0x26E1DF0", VA = "0x1826E37F0")]
		private void Awake()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x26E3E70", Offset = "0x26E2470", VA = "0x1826E3E70")]
		private void Update()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x26E4070", Offset = "0x26E2670", VA = "0x1826E4070")]
		private void OnMultiplayerInstanceTypeChanged()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x26E40C0", Offset = "0x26E26C0", VA = "0x1826E40C0")]
		private void EnableCurrentDisableOthers()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x26E4400", Offset = "0x26E2A00", VA = "0x1826E4400")]
		private void DisableAllCameras()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x26E4620", Offset = "0x26E2C20", VA = "0x1826E4620")]
		public void NextCamera()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x26E4690", Offset = "0x26E2C90", VA = "0x1826E4690")]
		public void PreviousCamera()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x26E46F0", Offset = "0x26E2CF0", VA = "0x1826E46F0")]
		private void CheckIfInside()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x26E4920", Offset = "0x26E2F20", VA = "0x1826E4920")]
		private void OnVehicleWake()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x26E4930", Offset = "0x26E2F30", VA = "0x1826E4930")]
		private void OnVehicleSleep()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x26E4940", Offset = "0x26E2F40", VA = "0x1826E4940")]
		public CameraChanger()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("    If true vehicleCameras list will be filled through cameraTag.")]
		public bool autoFindCameras;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("    Index of the camera from vehicle cameras list that will be active first.")]
		public int currentCameraIndex;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("vehicleCameras")]
		[Tooltip("List of cameras that the changer will cycle through. Leave empty if you want cameras to be automatically detected. To be detected cameras need to have camera tag and be children of the object this script is attached to.")]
		public List<GameObject> cameras;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		private int _previousCamera;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x38")]
		private Vehicle _vehicle;
	}
}
