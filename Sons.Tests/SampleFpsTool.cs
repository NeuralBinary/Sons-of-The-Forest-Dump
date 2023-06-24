using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Tests
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class SampleFpsTool : MonoBehaviour
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x314B4D0", Offset = "0x3149AD0", VA = "0x18314B4D0")]
		public Coroutine SampleAll()
		{
			return null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x314B6E0", Offset = "0x3149CE0", VA = "0x18314B6E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x314B6F0", Offset = "0x3149CF0", VA = "0x18314B6F0")]
		private void RefreshFrameTimings()
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x314BBD0", Offset = "0x314A1D0", VA = "0x18314BBD0")]
		private double GetMedianMainThreadWait(FrameTiming[] frameTimings, uint count)
		{
			return 0.0;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x314BD60", Offset = "0x314A360", VA = "0x18314BD60")]
		private double GetMedianGpu(FrameTiming[] frameTimings, uint count)
		{
			return 0.0;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x314BEF0", Offset = "0x314A4F0", VA = "0x18314BEF0")]
		private double GetMedianGpuThread(FrameTiming[] frameTimings, uint count)
		{
			return 0.0;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x314C080", Offset = "0x314A680", VA = "0x18314C080")]
		private double GetMedianMainThread(FrameTiming[] frameTimings, uint count)
		{
			return 0.0;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x314C240", Offset = "0x314A840", VA = "0x18314C240")]
		private double GetMedianCpu(FrameTiming[] frameTimings, uint count)
		{
			return 0.0;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x314C400", Offset = "0x314AA00", VA = "0x18314C400")]
		private bool TryImportOverrideLocations()
		{
			return default(bool);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x314C510", Offset = "0x314AB10", VA = "0x18314C510")]
		private void EnableSystem(bool value)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x314C710", Offset = "0x314AD10", VA = "0x18314C710")]
		private void Awake()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x314C810", Offset = "0x314AE10", VA = "0x18314C810")]
		private void Start()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x314C890", Offset = "0x314AE90", VA = "0x18314C890")]
		private bool DebugCommand(string arg)
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x314C8B0", Offset = "0x314AEB0", VA = "0x18314C8B0")]
		private void Update()
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x314C980", Offset = "0x314AF80", VA = "0x18314C980")]
		private IEnumerator SampleFpsWorker(List<SampleFpsLocation> locations)
		{
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x314CA80", Offset = "0x314B080", VA = "0x18314CA80")]
		private void UpdateScreenshotPrefix()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x314CDF0", Offset = "0x314B3F0", VA = "0x18314CDF0")]
		private void UpdateFpsReadout()
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x314CF20", Offset = "0x314B520", VA = "0x18314CF20")]
		private void RefreshVersionReadout()
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x314CF80", Offset = "0x314B580", VA = "0x18314CF80")]
		private void RefreshDeviceReadout()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x314D410", Offset = "0x314BA10", VA = "0x18314D410")]
		private void RefreshTimeOfDayReadout()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x314D580", Offset = "0x314BB80", VA = "0x18314D580")]
		private IEnumerator CaptureScreenShot(SampleFpsLocation eachLocation)
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
		public List<SampleResult> GetSampleResults()
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x314D680", Offset = "0x314BC80", VA = "0x18314D680")]
		public string GetSampleResultsCsv()
		{
			return null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
		public void SetSampleTime(float sampleTime)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x314D890", Offset = "0x314BE90", VA = "0x18314D890")]
		public SampleFpsTool()
		{
		}

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SampleFpsLocations _locations;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_delayBetweenLocations")]
		private float _delayBeforeSample;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _sampleTime;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TMP_Text _locationText;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_Text _fpsText;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_Text _timingText;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TMP_Text _timingLabelText;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_Text _versionText;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TMP_Text _deviceText;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TMP_Text _timeOfDayText;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _canvasGroup;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _autoDisable;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x74")]
		private float _fps;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x78")]
		private bool _capturing;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x80")]
		private string _screenshotPrefix;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x88")]
		private List<SampleResult> _sampleResults;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x90")]
		private FrameTiming[] _frameTimings;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x98")]
		private StringBuilder _stringBuilderBuffer;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0xA0")]
		private bool _initializedTimingLabels;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0xA4")]
		private int _lastFrameTimingFrame;

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000015")]
		public class Screenshot
		{
			// Token: 0x0600006C RID: 108 RVA: 0x0000221C File Offset: 0x0000041C
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x314D960", Offset = "0x314BF60", VA = "0x18314D960")]
			public bool Write(string path)
			{
				return default(bool);
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00002234 File Offset: 0x00000434
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x314DC20", Offset = "0x314C220", VA = "0x18314DC20")]
			public bool WriteWithExif(string path, string comment)
			{
				return default(bool);
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x314DCD0", Offset = "0x314C2D0", VA = "0x18314DCD0")]
			private static void Completed()
			{
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Screenshot()
			{
			}

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x10")]
			public byte[] Bytes;

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D Texture;
		}
	}
}
