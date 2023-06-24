using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Cameras
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class VehicleCamera : MonoBehaviour
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x26E82E0", Offset = "0x26E68E0", VA = "0x1826E82E0", Slot = "4")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VehicleCamera()
		{
		}

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Transform that this script is targeting. Can be left empty if head movement is not being used.")]
		public Vehicle target;
	}
}
