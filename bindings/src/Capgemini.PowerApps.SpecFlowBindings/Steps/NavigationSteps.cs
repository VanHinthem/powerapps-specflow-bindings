﻿namespace Capgemini.PowerApps.SpecFlowBindings.Steps
{
    using TechTalk.SpecFlow;

    /// <summary>
    /// Step bindings relating to navigation.
    /// </summary>
    [Binding]
    public class NavigationSteps : PowerAppsStepDefiner
    {
        /// <summary>
        /// Opens a sub-area from the navigation bar.
        /// </summary>
        /// <param name="subAreaName">The name of the sub-area.</param>
        /// <param name="areaName">The name of the area.</param>
        [When("I open the sub area '(.*)' under the '(.*)' area")]
        public static void WhenIOpenTheSubAreaUnderTheArea(string subAreaName, string areaName)
        {
            XrmApp.Navigation.OpenSubArea(areaName, subAreaName);
        }

        /// <summary>
        /// Opens global search.
        /// </summary>
        [When("I open global search")]
        public static void WhenIOpenGlobalSearch()
        {
            XrmApp.Navigation.OpenGlobalSearch();
        }

        /// <summary>
        /// Opens an area.
        /// </summary>
        /// <param name="areaName">The name of the area.</param>
        [When("I open the '(.*)' area")]
        public static void WhenIOpenTheArea(string areaName)
        {
            XrmApp.Navigation.OpenArea(areaName);
        }

        /// <summary>
        /// Opens a sub area of a group.
        /// </summary>
        /// <param name="subAreaName">The name of the sub area.</param>
        /// <param name="groupName">The name of the group.</param>
        [When("I open the '(.*)' sub area of the '(.*)' group")]
        public static void WhenIOpenTheSubAreaOfTheGroup(string subAreaName, string groupName)
        {
            XrmApp.Navigation.OpenGroupSubArea(groupName, subAreaName);
        }

        /// <summary>
        /// Opens a quick create for an entity.
        /// </summary>
        /// <param name="entity">The name of the entity.</param>
        [When("I open a quick create for the '(.*)' entity")]
        public static void WhenIOpenAQuickCreateForTheEntity(string entity)
        {
            XrmApp.Navigation.QuickCreate(entity);
        }

        /// <summary>
        /// Signs out.
        /// </summary>
        [When("I sign out")]
        public static void WhenISignOut()
        {
            XrmApp.Navigation.SignOut();
        }
    }
}