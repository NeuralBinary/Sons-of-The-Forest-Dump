using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace NWH.Common.SceneManagement
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VehicleChanger))]
	public class CharacterVehicleChanger : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x26F3D50", Offset = "0x26F2350", VA = "0x1826F3D50")]
		public CharacterVehicleChanger(Vehicle nearestVehicle)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x26F3E80", Offset = "0x26F2480", VA = "0x1826F3E80")]
		private void Awake()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x26F3F10", Offset = "0x26F2510", VA = "0x1826F3F10")]
		private void Start()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x26F3FE0", Offset = "0x26F25E0", VA = "0x1826F3FE0")]
		private void Update()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x26F4980", Offset = "0x26F2F80", VA = "0x1826F4980")]
		public void EnterExitVehicle()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		public static CharacterVehicleChanger Instance;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("characterControllerObject")]
		[Tooltip("    Game object representing a character. Can also be another vehicle.")]
		public GameObject characterObject;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.2f, 3f)]
		[Tooltip("    Maximum distance at which the character will be able to enter the vehicle.")]
		public float enterDistance;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Tag of the object representing the point from which the enter distance will be measured. Useful if you want to enable you character to enter only when near the door.")]
		public string enterExitTag;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("    Maximum speed at which the character will be able to enter / exit the vehicle.")]
		public float maxEnterExitVehicleSpeed;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("    True when character can enter the vehicle.")]
		public bool nearVehicle;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x3D")]
		private bool _insideVehicle;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x40")]
		private GameObject _nearestEnterExitObject;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x48")]
		private Vehicle _nearestVehicle;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _relativeEnterPosition;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x60")]
		private GameObject[] _enterExitPoints;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x68")]
		private GameObject _nearestEnterExitPoint;
	}
}
