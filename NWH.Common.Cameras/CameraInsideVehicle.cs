using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Cameras
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class CameraInsideVehicle : MonoBehaviour
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x26E53B0", Offset = "0x26E39B0", VA = "0x1826E53B0")]
		private void Awake()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x26E5440", Offset = "0x26E3A40", VA = "0x1826E5440")]
		private void Update()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public CameraInsideVehicle()
		{
		}

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("    Is the camera inside vehicle?")]
		public bool isInsideVehicle;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		private Vehicle _vehicle;
	}
}
