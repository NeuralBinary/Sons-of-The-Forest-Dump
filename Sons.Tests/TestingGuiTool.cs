using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class TestingGuiTool : MonoBehaviour
	{
		// Token: 0x0600012C RID: 300 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		public static bool GetFpsSamplerActive()
		{
			return default(bool);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void SetFpsSamplerActive(bool value)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x3154AD0", Offset = "0x31530D0", VA = "0x183154AD0")]
		private void EnableSystem(bool value)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x3154B90", Offset = "0x3153190", VA = "0x183154B90")]
		private void Start()
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x3154C10", Offset = "0x3153210", VA = "0x183154C10")]
		private void Update()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x3155070", Offset = "0x3153670", VA = "0x183155070")]
		private void UpdateFpsLarge()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x31552C0", Offset = "0x31538C0", VA = "0x1831552C0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x31554E0", Offset = "0x3153AE0", VA = "0x1831554E0")]
		private void UpdateMpReadout()
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x3155780", Offset = "0x3153D80", VA = "0x183155780")]
		private void UpdateFpsValue(double fps, TMP_Text tmpText)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x31558B0", Offset = "0x3153EB0", VA = "0x1831558B0")]
		private void UpdateFpsValue(ref float fps, TMP_Text tmpText, [Optional] string prefix, [Optional] string suffix)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x3155A10", Offset = "0x3154010", VA = "0x183155A10")]
		private void RefreshVersionReadout()
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x3155A70", Offset = "0x3154070", VA = "0x183155A70")]
		private void RefreshDeviceReadout()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x3155D60", Offset = "0x3154360", VA = "0x183155D60")]
		private void RefreshTimeOfDayReadout()
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x3155F20", Offset = "0x3154520", VA = "0x183155F20")]
		private void RefreshUpTimeReadout()
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x3155F60", Offset = "0x3154560", VA = "0x183155F60")]
		public TestingGuiTool()
		{
		}

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Text _locationText;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text _fpsTextLarge;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TMP_Text _versionText;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_Text _deviceText;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_Text _timeOfDayText;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TMP_Text _upTimeText;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_Text _mpText;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TMP_Text _clientHostText;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _canvasGroup;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private VisualWorldDebugGrid _visualWorldDebugGrid;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fps;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool _capturing;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _screenshotPrefix;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<SampleResult> _sampleResults;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<float> _fpsSamples;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private StringBuilder _fpsSamplesOutputBuffer;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _failFindVisualWorldDebugGrid;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool _requestedFpsDisplay;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		private bool _enabledSystem;
	}
}
