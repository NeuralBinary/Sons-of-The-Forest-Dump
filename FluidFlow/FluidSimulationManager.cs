using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FluidSimulation
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class FluidSimulationManager : MonoBehaviour
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public bool COMPUTESHADER_SUPPORT
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002208 File Offset: 0x00000408
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public bool ASYNCGPUREADBACK_SUPPORT
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x98F620", Offset = "0x98DC20", VA = "0x18098F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x1700000C")]
		public bool USE_INTEGER_RENDERTEXTURE
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xAFE1F0", Offset = "0xAFC7F0", VA = "0x180AFE1F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700000D")]
		public ComputeShader simulationShader
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xAFE200", Offset = "0xAFC800", VA = "0x180AFE200")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xAFE3A0", Offset = "0xAFC9A0", VA = "0x180AFE3A0")]
		public void EnqueueSimulator(FluidSimulator sim)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0xAFE400", Offset = "0xAFCA00", VA = "0x180AFE400")]
		public void RemoveSimulator(FluidSimulator sim)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0xAFE7B0", Offset = "0xAFCDB0", VA = "0x180AFE7B0")]
		public void CheckComputeShaderSupport()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event Action SimulationCycle
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0xAFE8E0", Offset = "0xAFCEE0", VA = "0x180AFE8E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xAFE9D0", Offset = "0xAFCFD0", VA = "0x180AFE9D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xAFEAC0", Offset = "0xAFD0C0", VA = "0x180AFEAC0")]
		private void UpdateInvokeTime()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700000E")]
		public static FluidSimulationManager instance
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xAFEBD0", Offset = "0xAFD1D0", VA = "0x180AFEBD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000036")]
		[Address(RVA = "0xAFEEC0", Offset = "0xAFD4C0", VA = "0x180AFEEC0")]
		public FluidSimulationManager.SharedSimulationData GetSharedData(FluidObject fluidObject)
		{
			return default(FluidSimulationManager.SharedSimulationData);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000037")]
		[Address(RVA = "0xAFF000", Offset = "0xAFD600", VA = "0x180AFF000")]
		public bool HasSharedData(FluidObject mesh)
		{
			return default(bool);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0xAFF070", Offset = "0xAFD670", VA = "0x180AFF070")]
		public void EnterSharedData(FluidObject fluidObject, FluidSimulationManager.SharedSimulationData simData)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0xAFF140", Offset = "0xAFD740", VA = "0x180AFF140")]
		public void ReleaseSharedData(FluidObject fluidObject)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public int loadTexelMapKernelID
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x8DCFD0", Offset = "0x8DB5D0", VA = "0x1808DCFD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public int updateGravVecKernelID
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xAFDBB0", Offset = "0xAFC1B0", VA = "0x180AFDBB0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xAF0770", Offset = "0xAEED70", VA = "0x180AF0770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public int updateGravMapNormalKernelID
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xAFF270", Offset = "0xAFD870", VA = "0x180AFF270")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xAF0780", Offset = "0xAEED80", VA = "0x180AF0780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public int updateGravMapKernelID
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xAFF280", Offset = "0xAFD880", VA = "0x180AFF280")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xAFF290", Offset = "0xAFD890", VA = "0x180AFF290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public int updateFluidKernelID
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xAFF2A0", Offset = "0xAFD8A0", VA = "0x180AFF2A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xAD49F0", Offset = "0xAD2FF0", VA = "0x180AD49F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		public int calcDripKernelID
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xAFF2B0", Offset = "0xAFD8B0", VA = "0x180AFF2B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xAFF2C0", Offset = "0xAFD8C0", VA = "0x180AFF2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public int textureBurshKernelID
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0xAFF2D0", Offset = "0xAFD8D0", VA = "0x180AFF2D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000047")]
			[Address(RVA = "0xAFF2E0", Offset = "0xAFD8E0", VA = "0x180AFF2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public int sphereBurshKernelID
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x65E0E0", Offset = "0x65C6E0", VA = "0x18065E0E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x65E0F0", Offset = "0x65C6F0", VA = "0x18065E0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public int discBrushKernelID
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xAFF300", Offset = "0xAFD900", VA = "0x180AFF300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public int resetFluidKernelID
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0xAFF310", Offset = "0xAFD910", VA = "0x180AFF310")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xAFF320", Offset = "0xAFD920", VA = "0x180AFF320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public int evapFluidKernelID
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xAFF330", Offset = "0xAFD930", VA = "0x180AFF330")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xAFF340", Offset = "0xAFD940", VA = "0x180AFF340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public int texelTexRID
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xAFF350", Offset = "0xAFD950", VA = "0x180AFF350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public int texelTexWID
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0xAFF360", Offset = "0xAFD960", VA = "0x180AFF360")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0xAFF370", Offset = "0xAFD970", VA = "0x180AFF370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public int fluidTexRID
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x728370", Offset = "0x726970", VA = "0x180728370")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x728380", Offset = "0x726980", VA = "0x180728380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public int fluidTexWID
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x728390", Offset = "0x726990", VA = "0x180728390")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x7283A0", Offset = "0x7269A0", VA = "0x1807283A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public int flowTexRID
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x7283B0", Offset = "0x7269B0", VA = "0x1807283B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x7283C0", Offset = "0x7269C0", VA = "0x1807283C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000023E8 File Offset: 0x000005E8
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public int flowTexWID
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x7283D0", Offset = "0x7269D0", VA = "0x1807283D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x7283E0", Offset = "0x7269E0", VA = "0x1807283E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002400 File Offset: 0x00000600
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public int brushTexID
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xAFF380", Offset = "0xAFD980", VA = "0x180AFF380")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xAFF390", Offset = "0xAFD990", VA = "0x180AFF390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002418 File Offset: 0x00000618
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public int normalTexID
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xAFF3A0", Offset = "0xAFD9A0", VA = "0x180AFF3A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xAFF3B0", Offset = "0xAFD9B0", VA = "0x180AFF3B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002430 File Offset: 0x00000630
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public int finalTexID
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0xAFF3C0", Offset = "0xAFD9C0", VA = "0x180AFF3C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0xAFF3D0", Offset = "0xAFD9D0", VA = "0x180AFF3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002448 File Offset: 0x00000648
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		public int texelBufferID
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0xAFF3E0", Offset = "0xAFD9E0", VA = "0x180AFF3E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xAFF3F0", Offset = "0xAFD9F0", VA = "0x180AFF3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002460 File Offset: 0x00000660
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public int fluidBufferID
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0xAFF400", Offset = "0xAFDA00", VA = "0x180AFF400")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0xAFF410", Offset = "0xAFDA10", VA = "0x180AFF410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002478 File Offset: 0x00000678
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public int tangentBufferID
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0xAFF420", Offset = "0xAFDA20", VA = "0x180AFF420")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0xAFF430", Offset = "0xAFDA30", VA = "0x180AFF430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public int gravityVecBufferID
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xAFF440", Offset = "0xAFDA40", VA = "0x180AFF440")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xAFF450", Offset = "0xAFDA50", VA = "0x180AFF450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000024A8 File Offset: 0x000006A8
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public int dropsBufferID
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xAFF460", Offset = "0xAFDA60", VA = "0x180AFF460")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xAFF470", Offset = "0xAFDA70", VA = "0x180AFF470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000024C0 File Offset: 0x000006C0
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public int boundsBufferID
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xAFF480", Offset = "0xAFDA80", VA = "0x180AFF480")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xAFF490", Offset = "0xAFDA90", VA = "0x180AFF490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000024D8 File Offset: 0x000006D8
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public int texelInputBufferID
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x67E8C0", Offset = "0x67CEC0", VA = "0x18067E8C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x67E8D0", Offset = "0x67CED0", VA = "0x18067E8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public int triangleDataBufferID
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x67E8E0", Offset = "0x67CEE0", VA = "0x18067E8E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x67E8F0", Offset = "0x67CEF0", VA = "0x18067E8F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002508 File Offset: 0x00000708
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public int gravityValueID
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xAFF4A0", Offset = "0xAFDAA0", VA = "0x180AFF4A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xAFF4B0", Offset = "0xAFDAB0", VA = "0x180AFF4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public int amountValueID
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xAFF4C0", Offset = "0xAFDAC0", VA = "0x180AFF4C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xAFF4D0", Offset = "0xAFDAD0", VA = "0x180AFF4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002538 File Offset: 0x00000738
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public int fluidSpeedValueID
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xAFF4E0", Offset = "0xAFDAE0", VA = "0x180AFF4E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xAFF4F0", Offset = "0xAFDAF0", VA = "0x180AFF4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002550 File Offset: 0x00000750
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public int roughnessValueID
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xAFF500", Offset = "0xAFDB00", VA = "0x180AFF500")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xAFF510", Offset = "0xAFDB10", VA = "0x180AFF510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public int texSizeValueID
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xAFF520", Offset = "0xAFDB20", VA = "0x180AFF520")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xAFF530", Offset = "0xAFDB30", VA = "0x180AFF530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		public int texSizeInvValueID
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xAFF540", Offset = "0xAFDB40", VA = "0x180AFF540")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xAFF550", Offset = "0xAFDB50", VA = "0x180AFF550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public int trisCountValueID
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0xAFF560", Offset = "0xAFDB60", VA = "0x180AFF560")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xAFF570", Offset = "0xAFDB70", VA = "0x180AFF570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public int sqrRadiusValueID
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xAFF580", Offset = "0xAFDB80", VA = "0x180AFF580")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xAFF590", Offset = "0xAFDB90", VA = "0x180AFF590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000025C8 File Offset: 0x000007C8
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public int brushDepthValueID
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xAFF5A0", Offset = "0xAFDBA0", VA = "0x180AFF5A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xAFF5B0", Offset = "0xAFDBB0", VA = "0x180AFF5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public int brushSizeInvValueID
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xAFF5C0", Offset = "0xAFDBC0", VA = "0x180AFF5C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xAFF5D0", Offset = "0xAFDBD0", VA = "0x180AFF5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public int minDripAmtValueID
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xAFF5E0", Offset = "0xAFDBE0", VA = "0x180AFF5E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xAFF5F0", Offset = "0xAFDBF0", VA = "0x180AFF5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public int dryAmountValueID
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xAFF600", Offset = "0xAFDC00", VA = "0x180AFF600")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xAFF610", Offset = "0xAFDC10", VA = "0x180AFF610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public int decayAmountValueID
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xAFF620", Offset = "0xAFDC20", VA = "0x180AFF620")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xAFF630", Offset = "0xAFDC30", VA = "0x180AFF630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002640 File Offset: 0x00000840
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		public int slopeAmountValueID
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xAFF640", Offset = "0xAFDC40", VA = "0x180AFF640")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xAFF650", Offset = "0xAFDC50", VA = "0x180AFF650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public int normalAmountValueID
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xAFF660", Offset = "0xAFDC60", VA = "0x180AFF660")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xAFF670", Offset = "0xAFDC70", VA = "0x180AFF670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public int drawDataID
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xAFF680", Offset = "0xAFDC80", VA = "0x180AFF680")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xAFF690", Offset = "0xAFDC90", VA = "0x180AFF690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0xAFF6A0", Offset = "0xAFDCA0", VA = "0x180AFF6A0")]
		private void cacheShaderIDs(ComputeShader compute)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0xB00700", Offset = "0xAFED00", VA = "0x180B00700")]
		private void Awake()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0xB00710", Offset = "0xAFED10", VA = "0x180B00710")]
		private void Update()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0xB00950", Offset = "0xAFEF50", VA = "0x180B00950")]
		private void simulationCycle()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0xB00A00", Offset = "0xAFF000", VA = "0x180B00A00")]
		private void updateFluidSimulators()
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB00A90", Offset = "0xAFF090", VA = "0x180B00A90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0xB00C90", Offset = "0xAFF290", VA = "0x180B00C90")]
		public FluidSimulationManager()
		{
		}

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x20")]
		public FluidSimulationManager.UpdateMode updateMode;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x24")]
		public int skipFrames;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x28")]
		public int cyclesPerSecond;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x2C")]
		public int maximumUpdatesPerCycle;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x30")]
		public bool onlyVisible;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x34")]
		public float minimumEvaporationDelta;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		public const int MULTI = 1000;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool useIntegerRendertexture;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x40")]
		private ComputeShader _simulationShader;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x50")]
		private Queue<FluidSimulator> updateQueue;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x58")]
		private FluidSimulationManager.UpdateMode lastUpdateMode;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x5C")]
		private int currentCyclesPerSecond;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x60")]
		private int skippedFrames;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x0")]
		private static FluidSimulationManager _instance;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<FluidObject, FluidSimulationManager.SharedSimulationData> sharedSimulationData;

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		public enum UpdateMode
		{
			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			Frame,
			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			Time
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		public struct SharedSimulationData
		{
			// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000099")]
			[Address(RVA = "0xB00EA0", Offset = "0xAFF4A0", VA = "0x180B00EA0")]
			public SharedSimulationData(RenderTexture texelMap, ComputeBuffer texelBuffer, ComputeBuffer tangentBuffer, ComputeBuffer boundsBuffer)
			{
			}

			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x0")]
			public RenderTexture texelMap;

			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x8")]
			public ComputeBuffer texelBuffer;

			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x10")]
			public ComputeBuffer tangentBuffer;

			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0x18")]
			public ComputeBuffer boundsBuffer;
		}
	}
}
