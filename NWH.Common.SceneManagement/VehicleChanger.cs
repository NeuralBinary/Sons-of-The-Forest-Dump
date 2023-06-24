using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.SceneManagement
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class VehicleChanger : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000001")]
		public static VehicleChanger Instance
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x26F4EF0", Offset = "0x26F34F0", VA = "0x1826F4EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x26F4F30", Offset = "0x26F3530", VA = "0x1826F4F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public static Vehicle ActiveVehicle
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x26F4FC0", Offset = "0x26F35C0", VA = "0x1826F4FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x26F5000", Offset = "0x26F3600", VA = "0x1826F5000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x26F50A0", Offset = "0x26F36A0", VA = "0x1826F50A0")]
		private void Awake()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x26F5140", Offset = "0x26F3740", VA = "0x1826F5140")]
		private void Start()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x26F52B0", Offset = "0x26F38B0", VA = "0x1826F52B0")]
		private void Update()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x26F55A0", Offset = "0x26F3BA0", VA = "0x1826F55A0")]
		private void RemoveNullVehicles()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x26F5750", Offset = "0x26F3D50", VA = "0x1826F5750")]
		public void ChangeVehicle(int index)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x26F57B0", Offset = "0x26F3DB0", VA = "0x1826F57B0")]
		public Vehicle NearestVehicleFrom(GameObject go)
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x26F5AC0", Offset = "0x26F40C0", VA = "0x1826F5AC0")]
		public void ChangeVehicle(Vehicle ac)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x26F5B80", Offset = "0x26F4180", VA = "0x1826F5B80")]
		public void NextVehicle()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x26F5C10", Offset = "0x26F4210", VA = "0x1826F5C10")]
		public void PreviousVehicle()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x26F5CB0", Offset = "0x26F42B0", VA = "0x1826F5CB0")]
		public void DeactivateAllExceptActive()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x26F5D90", Offset = "0x26F4390", VA = "0x1826F5D90")]
		public void DeactivateAllIncludingActive()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x26F5E40", Offset = "0x26F4440", VA = "0x1826F5E40")]
		public void FindVehicles()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x26F60C0", Offset = "0x26F46C0", VA = "0x1826F60C0")]
		public VehicleChanger()
		{
		}

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Is vehicle changing character based? When true changing vehicles will require getting close to them\r\nto be able to enter, opposed to pressing a button to switch between vehicles.")]
		public bool characterBased;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("    Index of the current vehicle in vehicles list.")]
		public int currentVehicleIndex;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("    Should the vehicles that the player is currently not using be put to sleep to improve performance?")]
		public bool putOtherVehiclesToSleep;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("List of all of the vehicles that can be selected and driven in the scene. If set to 0 script will try to auto-find all the vehicles in the scene with a tag define by VehiclesTag parameter.")]
		[SerializeField]
		public List<Vehicle> vehicles;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Tag that the script will search for if vehicles list is empty. Can be left empty if vehicles have already been assigned manually.")]
		public string vehicleTag;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("    While true all the vehicles are asleep.")]
		public bool deactivateAll;
	}
}
