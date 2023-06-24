using System;
using Il2CppDummyDll;
using Sons.Electricity;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	public interface IElectricDeviceSupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000AEF RID: 2799
		[Token(Token = "0x6000AEF")]
		bool CanHostNewElectricDevice();

		// Token: 0x06000AF0 RID: 2800
		[Token(Token = "0x6000AF0")]
		void GetPlaceInfo(out Vector3 pos, out Vector3 axis);

		// Token: 0x06000AF1 RID: 2801
		[Token(Token = "0x6000AF1")]
		Directions GetElectricDeviceDir();

		// Token: 0x06000AF2 RID: 2802
		[Token(Token = "0x6000AF2")]
		void SetElectricDevice(ElectricDeviceStructure electricDevice);

		// Token: 0x06000AF3 RID: 2803
		[Token(Token = "0x6000AF3")]
		Wire GetElectricWire();
	}
}
