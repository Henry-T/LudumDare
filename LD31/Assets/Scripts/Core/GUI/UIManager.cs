using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class UIManager : MonoBehaviour {
	public static UIManager Intance;

	public Transform UIRoot;

	public Dictionary<string, Panel> PanelDic = new Dictionary<string, Panel>();

	// Use this for initialization
	void Start () {
		Intance = this;

		if (UIRoot) {
			var panels = UIRoot.GetComponentsInChildren<Panel> ();
			foreach (var panel in panels) {
				PanelDic.Add(panel.name, panel);
			}
		}
		else
		{
			Debug.LogError("UIManager: UIRoot not assgned!");
		}
	}

	public void ShowPanel(string name) {
		var showPanel = PanelDic[name];
		if (showPanel)
			showPanel.gameObject.SetActive (true);
	}

	public void ClosePanel(string name) {
		var showPanel = PanelDic[name];
		if (showPanel)
			showPanel.gameObject.SetActive (false);
	}

	public void ShowPanelCloseOther(string name) {
		foreach (var panel in PanelDic.Values) {
			panel.gameObject.SetActive(false);
		}
		ShowPanel (name);
	}
}
