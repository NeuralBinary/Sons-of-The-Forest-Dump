using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[AddComponentMenu("Sons/FpsUtility/PerformanceRater")]
	public class PerformanceRater : MonoBehaviour
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2FE4230", Offset = "0x2FE2830", VA = "0x182FE4230")]
		private void OnEnable()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2FE42C0", Offset = "0x2FE28C0", VA = "0x182FE42C0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2FE4350", Offset = "0x2FE2950", VA = "0x182FE4350")]
		public void DumpDataToJson()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2FE4B20", Offset = "0x2FE3120", VA = "0x182FE4B20")]
		private void OpenWindowsExplorer(string dataPath)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2FE4C00", Offset = "0x2FE3200", VA = "0x182FE4C00")]
		private void SaveFileWithTimeStamp(string json)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2FE4D30", Offset = "0x2FE3330", VA = "0x182FE4D30")]
		private void Update()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2FE5240", Offset = "0x2FE3840", VA = "0x182FE5240")]
		public PerformanceRater()
		{
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _numFrames;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text _readout;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x30")]
		private float _cpuAverageFloat;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x34")]
		private float _gpuAverageFloat;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x38")]
		private float _fps;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x40")]
		private double _cpuAverage;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x48")]
		private double _gpuAverage;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x50")]
		private FrameTiming[] _frameTimingsBuffer;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x58")]
		private float[] _frameTimes;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x60")]
		private int _frameTimesIndex;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x64")]
		private bool _hasUpdatedReadout;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		private static string _persistentDataPath;
	}
}
